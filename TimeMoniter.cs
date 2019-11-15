using System;
using System.Collections.Generic;
using System.Text;

namespace CommonLib
{
    /// <summary>
    /// 时间监控
    /// </summary>
    public class TimeMoniter
    {
        private DateTime startTime;
        
        public TimeMoniter()
        {
            startTime = DateTime.Now;
        }

        //public void Start()
        //{
        //    startTime = DateTime.Now;

        //}
        public bool IsOverFlow()
        {
            if (startTime.AddMinutes(10).CompareTo(DateTime.Now) < 0)
                return true;
            return false;
        }
    }
}
