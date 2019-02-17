using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrungMoTo.Models.DTO
{
    public class UserModel
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string PassWord { get; set; }
        public int Role { get; set; }
        public int Status { get; set; }
    }
}