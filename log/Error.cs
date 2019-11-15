using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CommonLib.log
{
    public class Error:LogBase
    {
        public override void WriteLog(string logpath)
        {
            logpath = string.IsNullOrEmpty(logpath) ? defaultLogPath : logpath;
            StreamWriter sw = new StreamWriter(logpath, true);
            sw.WriteLine(string.Format("{0}  {1}  {2} ", CreateTime.ToString(), CurLevel, Content));
            sw.Close();
            sw.Dispose();
            //throw new NotImplementedException();
        }
    }
}
