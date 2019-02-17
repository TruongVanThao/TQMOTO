using TrungMoTo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrungMoTo.Controllers
{
    public class CustomerController : Controller
    {
        private Models.Service.CustomerService CustomerSevice = new Models.Service.CustomerService();

        public ActionResult Index()
        {
            string keySearch = Request.QueryString["q"];
            List<CustomerModel> listCustomer = CustomerSevice.searAllCustomer(keySearch);
            return View(listCustomer);
        }
    }
}