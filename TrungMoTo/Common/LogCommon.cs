using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Web.Hosting;

namespace TrungMoTo.Common
{
    public class LogCommon
    {
        public void WriteLogInfo(string strLog)
        {
            StreamWriter log;
            FileStream fileStream = null;
            DirectoryInfo logDirInfo = null;
            FileInfo logFileInfo;
            string dateTimeLog = "[" + System.DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss ").ToString() + "] ";
            dateTimeLog += strLog;
              
            string logFilePath = Path.Combine(HostingEnvironment.MapPath("~/File/Log/"));
            logFilePath = logFilePath + "InforLog-" + System.DateTime.Today.ToString("MM-dd-yyyy") + "." + "log";           
            logFileInfo = new FileInfo(logFilePath);
            logDirInfo = new DirectoryInfo(logFileInfo.DirectoryName);
            if (!logDirInfo.Exists) logDirInfo.Create();
            if (!logFileInfo.Exists)
            {
                fileStream = logFileInfo.Create();
            }
            else
            {
                fileStream = new FileStream(logFilePath, FileMode.Append);
            }
            log = new StreamWriter(fileStream);
            log.WriteLine(dateTimeLog);
            log.Close();
        }

        public void WriteLogError(string strLog)
        {
            StreamWriter log;
            FileStream fileStream = null;
            DirectoryInfo logDirInfo = null;
            FileInfo logFileInfo;
            string dateTimeLog = "[" + System.DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss ").ToString() + "] ";
            dateTimeLog += strLog;

            string logFilePath = Path.Combine(HostingEnvironment.MapPath("~/File/Log/"));
            logFilePath = logFilePath + "ErrorLog-" + System.DateTime.Today.ToString("MM-dd-yyyy") + "." + "log";
            logFileInfo = new FileInfo(logFilePath);
            logDirInfo = new DirectoryInfo(logFileInfo.DirectoryName);
            if (!logDirInfo.Exists) logDirInfo.Create();
            if (!logFileInfo.Exists)
            {
                fileStream = logFileInfo.Create();
            }
            else
            {
                fileStream = new FileStream(logFilePath, FileMode.Append);
            }
            log = new StreamWriter(fileStream);
            log.WriteLine(dateTimeLog);
            log.Close();
        }
    }
}