using System;
using System.Collections.Generic;
using System.Text;

namespace CommonLib.log
{
    public enum LogLevelEnmu { Normal, Error, Crash };
    public abstract class LogBase
    {
        protected static string defaultLogPath;
        public string Content
        {
            get;
            set;
        }
        public DateTime CreateTime
        {
            get;
            set;
        }
        public LogLevelEnmu CurLevel
        {
            get;
            set;
        }
        public LogBase()
        {
            Content = "";
            CreateTime = DateTime.Now;
            CurLevel = LogLevelEnmu.Normal;
            defaultLogPath = AppDomain.CurrentDomain.BaseDirectory + "BobLog.log";
        }
        abstract public void WriteLog(string logpath);
    }
}
