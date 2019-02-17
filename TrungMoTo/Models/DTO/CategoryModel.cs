using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrungMoTo.Models.DTO
{
    public class CategoryModel
    {
        public int CateoryId { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }
        public int Order { get; set; }
        public int Status { get; set; }
    }
}