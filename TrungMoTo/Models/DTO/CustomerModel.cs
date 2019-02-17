using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrungMoTo.Models
{

    public class CustomerModel
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Birthday { get; set; }
        public string Address { get; set; }
        public string Province { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
    }
}