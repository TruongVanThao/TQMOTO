using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrungMoTo.Models.Service
{
    public class CustomerService
    {
        private Repository.CustomerRepository CustomerDao = new Repository.CustomerRepository();

        public List<CustomerModel> searAllCustomer(string keySearch)
        {
            return CustomerDao.searchAll(keySearch);
        }
    }
}