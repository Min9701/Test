using System;
using System.Collections.Generic;

#nullable disable

namespace Test.Models
{
    public partial class Page
    {
        public int PageId { get; set; }
        public string PageName { get; set; }
        public string Contents { get; set; }
        public bool Published { get; set; }
        public DateTime? CreateAt { get; set; }
    }
}
