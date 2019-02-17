using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrungMoTo.Models.DTO;
using TrungMoTo.Models.Repository;

namespace TrungMoTo.Models.Service
{
    public class UserService
    {
        UserRepository UserRepository = new UserRepository();
        public UserModel checkLogin(string username, string pass)
        {
            return UserRepository.checkLogin(username, pass);
        }
    }
}