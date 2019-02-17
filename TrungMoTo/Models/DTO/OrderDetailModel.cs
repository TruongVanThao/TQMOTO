﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrungMoTo.Models.DTO
{
    public class OrderDetailModel
    {
        public int OrderDetailId { get; set; }
        public int Quantity { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public float Price { get; set; }
    }
}