using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Xml;
using Newtonsoft.Json;
using PlexEmailer.API;
using PlexEmailer.Models;
using PlexEmailer.Models.PlexXml;
using PlexEmailer.Utils;

using static PlexEmailer.Utils.Funcs;
using static PlexEmailer.Utils.Email;
using static PlexEmailer.Utils.GenerateMessage;

namespace PlexEmailer
{
    internal class Program
    {
        
        public static void Main(string[] args)
        {
            var options = new Options();
            if (CommandLine.Parser.Default.ParseArguments(args, options)) {
                RunAsync(options).Wait();
            }

        }
        
        static async Task RunAsync(Options options)
        {
            var media = new MediaTracker<VideoInstance>();
                
            var plexApi = new PlexApi();
            plexApi.baseUrl = options.Url;;
            plexApi.token = options.Token;;

            var t = DateTime.Today.AddDays(-7) - new DateTime(1970, 1, 1);
            var epochCutOff = (int)t.TotalSeconds;

            var libraryKeys = (await plexApi.ListDefinedLibraries()).Directory.Select(x => x.Key);
            foreach (var libraryKey in libraryKeys)
            {
                var section = plexApi.ListSectionContents(libraryKey);
                IEnumerable<Task<MediaContainer>> sections = new List<Task<MediaContainer>>() {section};
                
                // Movies are at the top level however TV shows are in <SHOW>, <SEASON> directories
                // This will traverse until we find the bottom directory
                var dirCount = (await section).Directory.Count;
                while (dirCount > 0)
                {
                    sections = sections
                        .Select(async x => await x)
                        .SelectMany(x => x.Result.Directory.Select(d => d.Key))
                        .Select(k => plexApi.ByKey(k));
                    
                    dirCount = sections
                        .Select(async s => await s)
                        .Select(s => s.Result).Select(s => s.Directory.Count).Sum();
                }

                var video = sections
                    .Select(async s => await s)
                    .Select(s => s.Result)
                    .SelectMany(s => s.Video)
                    .Where(x => int.Parse(x.AddedAt) > epochCutOff)
                    .Select(x => VideoToInstance.Invoke(x));

                if (video.Any())
                {
                    if (options.Verbose)
                    {
                        PrintVideos.Invoke(video);
                    }
                    media.Add(libraryKey, video);
                }
            }

            Console.WriteLine(GenerateEmail(media));
            if (media.internalDictionary.Count > 0 && options.Quiet == false)
            {
                foreach (var s in options.Emails.Split(',').Where(x => !string.IsNullOrEmpty(x)))
                {
                    SendEmail(options.From, s, options.Password, "Plex Weekly Update", GenerateEmail(media));
                }
            }
        }

    }
    
}