using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrungMoTo.Common;
using TrungMoTo.Models.DTO;

namespace TrungMoTo.Models.Repository
{
    public class UserRepository
    {
        private MySqlConnection connection;
        private MySqlCon mySqlCn = new MySqlCon();
        private LogCommon log = new LogCommon();
        private ComonUtil CMUtil = new ComonUtil();
        private string fileName = "User.xml";
        public UserModel checkLogin(string username, string password)
        {
            connection = mySqlCn.GetConnection();
            string sql = CMUtil.GetSqlQueryById(fileName, "UserLogin");
            UserModel user = null;
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = string.Format(sql, username, password);

                MySqlDataReader reader = cmd.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        user = new UserModel();
                        user.UserId = int.Parse(reader.GetString(0));
                        user.Name = reader.GetString(1);
                        user.Username = reader.GetString(2);
                        user.PassWord = reader.GetString(3);
                        user.Role = int.Parse(reader.GetString(4));
                        user.Status = int.Parse(reader.GetString(5));
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
            return user;
        }
    }
}