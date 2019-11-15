using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using CommonLib.log;

namespace CommonLib
{
   public  class CommonFunc
    {
       public static string DateTimeFormat = "yyyy-MM-dd HH:mm:ss";
       public static string DateTimeFormatCN = "yyyy年MM月dd日 HH:mm:ss";
       public static string DateFormatCN = "yyyy年MM月dd日";
       public static string DateFormatEN = "yyyy-MM-dd";
       public static string DateShortFormat = "yyyyMMdd";
       public static CommonFunc Instance = new CommonFunc();

       private CommonFunc()
       {
           
       }

       /// <summary> 
       /// MD5　32位加密 
       /// </summary> 
       /// <param name="str">加密的格式</param> 
       /// <returns></returns> 
       public static string Md5_32(string str)
       {
           string cl = str;
           string pwd = "";
           MD5 md5 = MD5.Create();
           byte[] s = md5.ComputeHash(Encoding.UTF8.GetBytes(cl));
           for (int i = 0; i < s.Length; i++)
           {
               pwd = pwd + s[i].ToString("X");
           }
           return pwd;
       }
       /// <summary>
       /// 加密
       /// </summary>
       /// <param name="str"></param>
       /// <returns></returns>
       public string Encode(string str)
       {
           string htext = "";

           for (int i = 0; i < str.Length; i++)
           {
               htext = htext + (char) (str[i] + 10 - 1*2);
           }
           return htext;
       }
       /// <summary>
       /// 解密
       /// </summary>
       /// <param name="str"></param>
       /// <returns></returns>
       public string Decode(string str)
       {
           string dtext = "";

           for (int i = 0; i < str.Length; i++)
           {
               dtext = dtext + (char) (str[i] - 10 + 1*2);
           }
           return dtext;
       }

       /// <summary>    
        ///  实现数据的真正的四舍五入法　　 
        /// </summary>    
        /// <param name="val">要进行处理的数据</param>    
        /// <param name="len">保留的小数位数</param>    
        ///  <returns>四舍五入后的结果</returns>    
        public  Decimal Round(Decimal val, int len)
        {
            int isNegative = 1;
            //如果是负数       
            if (val < 0)
            {
                isNegative = -1;
                val = -val;
            }
            string tempStr = val.ToString();
            if (tempStr.IndexOf('.') > 0 && tempStr.Length - tempStr.IndexOf('.') - 1 < len)
            {

            }
            else
            {

                Decimal tempval = DoubleRoundSubString(val, len);

                int i = 0;
                if (tempStr.IndexOf('.') > 0 && tempStr.Length >= tempStr.IndexOf('.') + len + 1 + 1)
                    i = int.Parse(tempStr.Substring(tempStr.IndexOf('.') + len + 1, 1));
                if (i > 4)
                {
                    val = tempval + Decimal.Parse((1 / Math.Pow(10, len)).ToString());
                }
                val = DoubleRoundSubString(val, len);

            }


            return val * isNegative;
        }

        /// <summary>
        /// 截取小数长度
        /// </summary>
        /// <param name="val"></param>
        /// <param name="len">长度</param>
        /// <returns></returns>
        public  Decimal DoubleRoundSubString(Decimal val, int len)
        {
            int isNegative = 1;
            //如果是负数       
            if (val < 0)
            {
                isNegative = -1;
                val = -val;
            }

            string tempVal = val.ToString();

            if (tempVal.IndexOf(".") > 0 && tempVal.Length - 1 - tempVal.IndexOf(".") > len)
                return Decimal.Parse(tempVal.Substring(0, tempVal.ToString().IndexOf('.') + len + 1)) * isNegative;
            else
                return Decimal.Parse(tempVal) * isNegative;
        }


        /// <summary>    
        ///  实现数据的真正的四舍五入法　　 
        /// </summary>    
        /// <param name="val">要进行处理的数据</param>    
        /// <param name="len">保留的小数位数</param>    
        ///  <returns>四舍五入后的结果</returns>    
        public double Round(double val, int len)
        {
            int isNegative = 1;
            //如果是负数       
            if (val < 0)
            {
                isNegative = -1;
                val = -val;
            }
            string tempStr = val.ToString();
            if (tempStr.IndexOf('.') > 0 && tempStr.Length - tempStr.IndexOf('.') - 1 < len)
            {
                return double.Parse(tempStr) * isNegative;
            }
            else
            {

                double tempval = DoubleRoundSubString(val, len);

                int i = 0;
                if (tempStr.IndexOf('.') > 0 && tempStr.Length >= tempStr.IndexOf('.') + len + 1 + 1)
                    i = int.Parse(tempStr.Substring(tempStr.IndexOf('.') + len + 1, 1));
                if (i > 4)
                {
                    val = tempval + double.Parse((1 / Math.Pow(10, len)).ToString());
                }
                val = DoubleRoundSubString(val, len);

            }


            return val * isNegative;
        }

        /// <summary>
        /// 截取小数长度
        /// </summary>
        /// <param name="val"></param>
        /// <param name="len">长度</param>
        /// <returns></returns>
        public double DoubleRoundSubString(double val, int len)
        {
            int isNegative = 1;
            //如果是负数       
            if (val < 0)
            {
                isNegative = -1;
                val = -val;
            }

            string tempVal = val.ToString();

            if (tempVal.IndexOf(".") > 0 && tempVal.Length - 1 - tempVal.IndexOf(".") > len)
                return double.Parse(tempVal.Substring(0, tempVal.ToString().IndexOf('.') + len + 1)) * isNegative;
            else
                return double.Parse(tempVal) * isNegative;
        }

       public string DoubleToString(double v)
       {
           if (v.CompareTo(double.NaN) == 0)
               return "非数字";
           else
               return v.ToString();
       }
       public string BoolToYesOrNoStr(bool  val)
       {
           return val ? "是" : "否";
       }
       
       #region 日志
       /// <summary>
       /// 写日志
       /// </summary>
       /// <param name="content"></param>
       public static void WriteNormalLog(string content)
       {
           Normal myLog = new Normal();
           myLog.Content = content;
           myLog.CreateTime = DateTime.Now;
           myLog.CurLevel = LogLevelEnmu.Normal;
           myLog.WriteLog(null);
       }
       /// <summary>
       /// 错误日志
       /// </summary>
       /// <param name="content"></param>
       public static void WriteErrorLog(string content)
       {
           Error myLog = new Error();
           myLog.Content = content;
           myLog.CreateTime = DateTime.Now;
           myLog.CurLevel = LogLevelEnmu.Error;
           myLog.WriteLog(null);
       }
       /// <summary>
       /// 指定路径日志
       /// </summary>
       /// <param name="logpath"></param>
       /// <param name="content"></param>
       public static void WriteTextLog(string logpath, string content)
       {
           if (!System.IO.Directory.Exists(Path.GetDirectoryName(logpath)))
           {
               Directory.CreateDirectory(Path.GetDirectoryName(logpath));
           }
           StreamWriter sw = new StreamWriter(logpath, true);
           sw.WriteLine(string.Format("{0}  {1}  {2} ", DateTime.Now, "textLog", content));
           sw.Close();
       }

       #endregion

       #region 字符串
       /// <summary>
       /// 判断指定字符串在指定字符串数组中的位置
       /// </summary>
       /// <param name="strSearch">字符串</param>
       /// <param name="stringArray">字符串数组</param>
       /// <param name="caseInsensetive">是否不区分大小写, true为不区分, false为区分</param>
       /// <returns>字符串在指定字符串数组中的位置, 如不存在则返回-1</returns>
       public static int GetInArrayID(string strSearch, string[] stringArray, bool caseInsensetive)
       {
           for (int i = 0; i < stringArray.Length; i++)
           {
               if (caseInsensetive)
               {
                   if (strSearch.ToLower() == stringArray[i].ToLower())
                   {
                       return i;
                   }
               }
               else
               {
                   if (strSearch == stringArray[i])
                   {
                       return i;
                   }
               }

           }
           return -1;
       }

       /// <summary>
       /// 判断指定字符串是否属于指定字符串数组中的一个元素
       /// </summary>
       /// <param name="strSearch">字符串</param>
       /// <param name="stringArray">字符串数组</param>
       /// <param name="caseInsensetive">是否不区分大小写, true为不区分, false为区分</param>
       /// <returns>判断结果</returns>
       public static bool InArray(string strSearch, string[] stringArray, bool caseInsensetive)
       {
           return GetInArrayID(strSearch, stringArray, caseInsensetive) >= 0;
       }
       public string RmoveAllTrim(string str)
       {
           return str.Replace(" ", "").Replace("　", "");
       }
       #endregion
       /// <summary>
       /// 判断是否是数字
       /// </summary>
       /// <param name="str">字符串</param>
       /// <returns></returns>
       public static bool IsNumeric(string str)
       {
           if (str == null || str.Length == 0)
               return false;
           ASCIIEncoding ascii = new ASCIIEncoding();
           byte[] bytestr = ascii.GetBytes(str);
           foreach (byte c in bytestr)
           {
               if (c < 48 || c > 57)
               {
                   return false;
               }
           }
           return true;
       }
       public static bool IsDouble(string val)
       {
           try
           {
               Convert.ToDouble(val);
               return true;
           }
           catch
           {
               return false;
           }
       }
       //最小日期判断
       public static bool IsMinDate(object d)
       {
           try
           {
               return Convert.ToDateTime(d).Equals(DateTime.MinValue);

           }
           catch
           {
               return true;
           }
       }
       public static string GetZh_CnDateString(object d)
       {

           try
           {
               System.Globalization.DateTimeFormatInfo myDTFI =
                   new System.Globalization.CultureInfo("zh-cn", true).DateTimeFormat; //中国用zh-cn 
               return Convert.ToDateTime(d, myDTFI).ToString("yyyy-MM-dd HH:mm:ss");
           }
           catch
           {

               return DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
           }
       }

       public static string SubString(string str, int length)
       {
           string resultString = str;
           int blength = Encoding.Default.GetByteCount(str);
           if (blength <= length)
               return resultString;

           bool result = false;
           int tempLen = blength;
           int i = 0;
           while (!result)
           {
               try
               {
                   resultString = str.Substring(0, blength - i);
                   tempLen = Encoding.Default.GetByteCount(resultString);
                   if (tempLen > length)
                   {
                       i++;
                       continue;
                   }
                   return resultString;
               }
               catch
               {
                   i++;
               }
           }
           return resultString;
       }
       public string[] SplitString(string str)
       {
           str = str.Replace("  ", " ");
           string[] result = str.Trim().Split(' ');
           string tempStr = string.Empty;
           foreach (string s in result)
           {
               if (!string.IsNullOrEmpty(s))
               {
                   if (string.IsNullOrEmpty(tempStr))
                       tempStr += s;
                   else
                   {
                       tempStr += " " + s;
                   }
               }
           }
           return tempStr.Split(' ');
       }

       // 有效清除文本中空白符
       public static string CleanSpace(string clean, string replace)
       {
           clean = Regex.Replace(clean, "[\\s]", "");
           return Regex.Replace(clean, " ", "");
       }
       // 处理输入关键字非字母、数字、汉字内容
       public static string KeywordCleaner(string keywrd)
       {
           return Regex.Replace(keywrd, "[^,，。！？.?!、;:\"\"；：“”a-zA-Z0-9\u4E00-\u9FA5\uF900-\uFA2D]", "");
       }

       // 清洗文本内容
       public static string CleanText(string clean)
       {
           clean = CleanTextFromHtml(clean);
           clean = CleanTagText(clean);
           clean = CleanSpace(clean, " ");
           clean = CleanRepeat(clean);
           clean = KeywordCleaner(clean);
           return clean;
       }

       // 清洗重复串
       public static string CleanRepeat(string clean)
       {
           return Regex.Replace(clean, "[？?,，。！!.、;:\"\"；：“”]{2,}", "");
       }
       // 清除文本内容中的html标签
       public static string CleanTextFromHtml(string clean)
       {
           clean = clean.Replace("&lt;", "<");
           clean = clean.Replace("&gt;", ">");
           return Regex.Replace(clean, "<(S*?)[^>]*>.*?|<.*? />", "");
       }
       // 获取标签内容
       public static string CleanTagText(string clean)
       {
           return Regex.Replace(clean, "&[a-z;]*;", "");
       }
    }
}
