using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrungMoTo.Models.DTO
{
    public class OrderModel
    {
        public int OrderId { get; set; }
        public string Datetime { get; set; }
        public float TotalMoney { get; set; }
        public int CustomerId { get; set; }
        public int Type { get; set; }
        public int Status { get; set; }
    }
}