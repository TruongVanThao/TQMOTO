using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using TrungMoTo.Common;
using System.Configuration;
using System.Linq;
using System.Web;

namespace TrungMoTo.Models
{
    public class MySqlCon 
    {
        private MySqlConnection connection;
        private LogCommon log = new LogCommon();

        public MySqlConnection GetConnection()
        {
            connection = new MySqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["MySQLConnection"].ConnectionString;
            if (OpenConnection())
            {
                log.WriteLogInfo("Connect database successly...");
            }
            else
            {
                log.WriteLogError("Database Connection Error...");
            }
            return connection;
        }

        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (Exception e)
            {
                log.WriteLogInfo(e.Message);
                return false;
            }
        }
    }
    
}