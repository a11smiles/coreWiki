using System;
using System.Collections.Generic;

namespace CoreWiki.Data.Entities
{
    public class Page
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public List<PageHistory> History { get; set; } = new List<PageHistory>();
    }
}