using System;
using System.Collections.Generic;

#nullable disable

namespace Test.Models
{
    public partial class News
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Contents { get; set; }
        public bool Published { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Author { get; set; }
        public int? AccountId { get; set; }
        public bool? IsHot { get; set; }
        public bool? IsNewFeed { get; set; }
        public int? Views { get; set; }
    }
}
