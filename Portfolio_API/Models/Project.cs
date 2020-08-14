using System;
namespace Portfolio_API.Models
{
    public class Project
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Creator { get; set; }
        public string User { get; set; }
        public Uri Url { get; set; }
        public string Type { get; set; }
        public Uri Img { get; set; }
        public string Description { get; set; }
        public System.Collections.Generic.List<string> Technologies { get; set; }
    }
}
