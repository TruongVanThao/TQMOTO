using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrungMoTo.Models.DTO;
using TrungMoTo.Models.Service;

namespace TrungMoTo.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Logout()
        {
            Session.Remove("username");
            Session.Remove("name");
            Session.Remove("role");
            return RedirectToAction("Login");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CheckLogin(string username, string password)
        {
            UserService UserService = new UserService();
            UserModel User = new UserModel();
            if (ModelState.IsValid)
            {
                User = UserService.checkLogin(username, password);
                if (User != null)
                {
                    Session["username"] = User.Username;
                    Session["name"] = User.Name;
                    Session["role"] = User.Role;
                    return RedirectToAction("Index", "Customer");  
                }
            }
            return RedirectToAction("Login");
        }
    }
}
