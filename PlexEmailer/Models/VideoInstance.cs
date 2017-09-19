using System;
using System.Reflection;
using System.Text;

namespace PlexEmailer.Models
{
    public class VideoInstance
    {
        public string Title { get; set; }
        public string Episode { get; set; }
        public string Summary { get; set; }
        public string Thumbnail { get; set; }

        public VideoInstance(string title, string episode, string summary, string thumbnail)
        {
            this.Title = title;
            this.Episode = episode;
            this.Summary = summary;
            this.Thumbnail = thumbnail;
        }

        public override string ToString()
        {
            if (Episode == null)
            {
                return "Title: " + this.Title + "\nSummary: " + this.Summary + "\nThumbnail: " + this.Thumbnail + "\n";
            }
            else
            {
                return "Title: " + this.Title + "\nEpisode: " + this.Episode + "\nSummary: " + this.Summary + "\nThumbnail: " + this.Thumbnail + "\n";
            }
        }
    }
}