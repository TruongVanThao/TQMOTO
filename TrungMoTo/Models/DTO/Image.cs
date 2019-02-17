using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrungMoTo.Models.DTO
{
    public class Image
    {
        public int ImageId { get; set; }
        public string Path { get; set; }
        public int NewId { get; set; }
        public int ProductId { get; set; }
    }
}