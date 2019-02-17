using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Xml;

namespace TrungMoTo.Common
{
    public class ComonUtil
    {
        public string GetSqlQueryById(string fileName, string id)
        {
            string sql = "";
            XmlDocument doc = new XmlDocument();
            string path = Path.Combine(HostingEnvironment.MapPath("~/File/Xml"), fileName);
            doc.Load(path);
            XmlNodeList xnList = doc.SelectNodes("/sqls/sql[@id='"+id+"']");
            sql = xnList.Item(0).InnerText;
            return sql;
        }
    }
}