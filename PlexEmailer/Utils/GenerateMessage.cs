using System;
using System.Collections.Generic;
using System.Linq;
using PlexEmailer.Models;

// There are better ways to generate html in C# but this was easy and fast so it won out
namespace PlexEmailer.Utils
{
    public static class GenerateMessage
    {
        public static string GenerateEmail(MediaTracker<VideoInstance> media)
        {
            const string opening = "<table border='1'>";
            const string closing = "</table>";

            var rows = new List<string>();

            foreach(var entry in media.internalDictionary)
            {
                if (string.IsNullOrEmpty(entry.Value.First().Title))
                {
                    rows.Add(opening);
                    rows.Add("<tr><th>Title</th><th>Summary</th></tr>");
                    rows.AddRange(entry.Value.Select(x => "<tr><td>" + x.Episode + "</td><td>" + x.Summary + "</td></tr>"));
                    rows.Add(closing);
                }
                else
                {
                    rows.Add(opening);
                    rows.Add("<tr><th>Show</th><th>Episode</th><th>Summary</th></tr>");
                    rows.AddRange(entry.Value.Select(x => "<tr><td>" + x.Title + "</td><td>" + x.Episode + "</td><td>" + x.Summary + "</td></tr>"));
                    rows.Add(closing);
                }
                rows.Add("<br/>");
                rows.Add("<br/>");
            }
            
            return string.Join("", rows);
        }
    }
}