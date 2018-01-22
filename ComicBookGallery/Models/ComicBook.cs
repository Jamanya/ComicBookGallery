using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBookGallery.Models
{
    public class ComicBook
    {
        public int Id { get; set; }
        public string SeriesTitle { get; set; }
        public int IssueNumber { get; set; }
        public string DescriptionHtml { get; set; }
        public Artists[] Artists { get; set; }
        public bool Favorite { get; set; }

        public string DisplayText { get { return SeriesTitle + " #" + IssueNumber; } }

        //prop for display images series-title-issue-number.jpg
        public string CoverFileImage
        {
            get
            {
                return SeriesTitle.Replace(" ", "-")
                .ToLower() + "-" + IssueNumber + ".jpg";
            }

        }
    }
}