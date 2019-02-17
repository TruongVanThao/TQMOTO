using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using TrungMoTo.Models;
using TrungMoTo.Common;
using System.Configuration;
using System.Web;

namespace TrungMoTo.Models.Repository
{
    public class CustomerRepository
    {
        private MySqlConnection connection;
        private MySqlCon mySqlCn = new MySqlCon();
        private LogCommon log = new LogCommon();
        private ComonUtil CMUtil = new ComonUtil();
        private string fileName = "Customer.xml";
        public List<CustomerModel> searchAll(string keySearch)
        {
            
            connection = mySqlCn.GetConnection();
            List<CustomerModel> listCustomer = new List<CustomerModel>();
            string sql = CMUtil.GetSqlQueryById(fileName, "SelectCustomer");
            
            string whereClause = "";
            if (keySearch != null && keySearch != "")
            {
                whereClause = " where Name  LIKE '%{0}%'";
            }
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = string.Format(sql+whereClause,keySearch);

                MySqlDataReader reader = cmd.ExecuteReader();
                try
                {
                    CustomerModel CustomerModel;
                    while(reader.Read())
                    {
                      CustomerModel = new CustomerModel();
                      CustomerModel.CustomerId = int.Parse(reader.GetString(0));
                      CustomerModel.Name = reader.GetString(1);
                      CustomerModel.Birthday = reader.GetString(2).Substring(0,10);
                      CustomerModel.Address = reader.GetString(3);
                      CustomerModel.Province = reader.GetString(4);
                      CustomerModel.Tel = reader.GetString(5);
                      CustomerModel.Email = reader.GetString(6);
                      listCustomer.Add(CustomerModel);
                    }
                    reader.Close();
                }
                catch (MySqlException e)
                {
                    string MessageString = "Read error occurred  / entry not found loading the Column details: "
                        + e.ErrorCode + " - " + e.Message + "; \n\nPlease Continue";
                    log.WriteLogError(MessageString);
                    reader.Close();
                }
            }
            catch (MySqlException e)
            {
                string MessageString = "The following error occurred loading the Column details: "
                    + e.ErrorCode + " - " + e.Message;
                log.WriteLogError(MessageString);
            }
            connection.Close();
            return listCustomer;
        }

    }
}