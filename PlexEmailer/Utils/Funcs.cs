using System;
using System.Collections.Generic;
using System.Linq;
using PlexEmailer.Models;
using PlexEmailer.Models.PlexXml;

namespace PlexEmailer.Utils
{
    public static class Funcs
    {
        public static Func<Video, VideoInstance> VideoToInstance = (x) => 
            new VideoInstance(x.GrandparentTitle, x.Title, x.Summary, x.Thumb);

        public static Action<IEnumerable<VideoInstance>> PrintVideos = (x) =>
            x.ToList().ForEach(v => Console.WriteLine(v.ToString()));
    }
}