using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CommonLib.log
{
    public class Normal:LogBase
    {
        static StringBuilder logStringBuilder = new StringBuilder("");

        
        public override void WriteLog(string logpath)
        {
            logpath = string.IsNullOrEmpty(logpath) ? defaultLogPath : logpath;
            using (StreamWriter sw = new StreamWriter(logpath, true))
            {
                sw.WriteLine(string.Format("{0}  {1}  {2} ", CreateTime.ToString(), CurLevel, Content));
                sw.Close();
                sw.Dispose();
            }
            //throw new NotImplementedException();
        }
        
        public static void AppenLog(LogBase log)
        {
            logStringBuilder.Append(log);
        }
    }
}
