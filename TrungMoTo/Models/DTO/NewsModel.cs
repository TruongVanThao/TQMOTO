using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrungMoTo.Models.DTO
{
    public class NewsModel
    {
        public int NewId { get; set; }
        public string Target { get; set; }
        public string Content { get; set; }
        public string Datetime { get; set; }
        public string AuthorId { get; set; }
        public int View { get; set; }
        public int Rate { get; set; }
    }
}