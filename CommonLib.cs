using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Xml.Serialization;

namespace CommonLib
{
    public class CommonLib
    {
        
        public static void GenXmlNode(object obj, XmlNode parentNode)
        {
            if (obj == null)
                return;

            foreach (System.Reflection.PropertyInfo p in obj.GetType().GetProperties())
            {
                XmlNode node = parentNode.OwnerDocument.CreateElement(p.Name);
                if (p.GetValue(obj, null) != null)
                    node.InnerText = p.GetValue(obj, null).ToString();
                parentNode.AppendChild(node);
            }
        }
        public static void FillObjVal(object obj, XmlNode srcNode)
        {
            foreach (XmlNode node in srcNode.ChildNodes)
            {
                SetObjVal(obj, node);
            }
        }
        public static void SetObjVal(object obj, XmlNode node)
        {
            foreach (System.Reflection.PropertyInfo p in obj.GetType().GetProperties())
            {
                if (p.Name == node.Name&&p.CanWrite)
                {
                    if (string.IsNullOrEmpty(node.InnerText) == null)
                        break;
                    if (p.GetValue(obj, null) is double)
                        p.SetValue(obj, Convert.ToDouble(node.InnerText), null);
                    else if (p.GetValue(obj, null) is int)
                        p.SetValue(obj, Convert.ToInt16(node.InnerText), null);
                    else if (p.GetValue(obj, null) is decimal)
                        p.SetValue(obj, Convert.ToDecimal(node.InnerText), null);
                    else
                        p.SetValue(obj, node.InnerText, null);
                    break;
                }

            }
        }
        public static void ClearTextBox(Control parentControl)
        {
            if (parentControl is TextBox)
            {
                parentControl.Text = "";
                return;
            }
            foreach (Control ct in parentControl.Controls)
            {
                if (ct is TextBox)
                    ct.Text = "";
                else if (ct is ComboBox)
                    (ct as ComboBox).SelectedIndex = 0;
                else if (ct is GroupBox)
                    ClearTextBox(ct);
            }
        }
        public static bool CheckTextBoxIsNotNull(Control parentControl)
        {
            if (parentControl is TextBox)
            {
                return !textBoxIsNull(parentControl);
            }
            foreach (Control ct in parentControl.Controls)
            {
                if (textBoxIsNull(ct))
                    return false;
            }
            return true;
        }

        private static bool textBoxIsNull(Control ct)
        {
            if (ct is TextBox && !(ct as TextBox).Multiline && !(ct as TextBox).ReadOnly)
            {
                if (ct.Enabled && ct.Visible && string.IsNullOrEmpty(ct.Text) && ct.Text != "无")
                {
                    ct.Focus();
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// 递归查检含有未录入数据 
        /// </summary>
        /// <param name="parentControl"></param>
        /// <returns></returns>
        public static bool CheckTextBoxInGroupboxIsNull(Control parentControl)
        {
            bool result = false;
            foreach (Control control in parentControl.Controls)
            {
                if(control is TextBox&&(control as TextBox).ReadOnly==false)
                {
                    if (textBoxIsNull(control) && control.Enabled)
                    {
                        return true;
                    }
                }
                else if(control is GroupBox)
                {
                    result = CheckTextBoxInGroupboxIsNull(control);
                }
            }
            return result;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tb">文本框</param>
        /// <param name="obj">对象</param>
        /// <param name="preStr">文本命名前缀</param>
        public static void SetTextVal(TextBox tb, object obj, string preStr)
        {
            if (tb == null) return;

            try
            {


                foreach (System.Reflection.PropertyInfo p in obj.GetType().GetProperties())
                {
                    string pName = string.IsNullOrEmpty(preStr) ? p.Name : preStr + p.Name;
                    if (pName == tb.Name)
                    {
                        if (p.GetValue(obj, null) != null)
                            tb.Text = p.GetValue(obj, null).ToString();
                        else
                        {
                            tb.Text = null;
                        }
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                CommonFunc.WriteErrorLog(ex.StackTrace + " msg " + ex.Message);
                return;
                
            }
        }
        public  static  string GetTextVal(TextBox textBox)
        {
            if (!string.IsNullOrEmpty(textBox.Text.Trim()))
                return textBox.Text.Trim();
            return "";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tb">文本框</param>
        /// <param name="obj">对象</param>
        /// <param name="preStr">文本命名前缀</param>
        public static bool SetValFromText(TextBox tb, object obj,string preStr)
        {

            bool result = false; try
            {
                foreach (System.Reflection.PropertyInfo p in obj.GetType().GetProperties())
                {
                    string pName = string.IsNullOrEmpty(preStr) ? p.Name : preStr + p.Name;
                    if (pName == tb.Name)
                    {
                        if (p.GetValue(obj, null) is double || p.GetValue(obj,null) is Double)
                        {
                            if (!string.IsNullOrEmpty(tb.Text))
                                p.SetValue(obj, Convert.ToDouble(tb.Text), null);
                            result = true;
                            break;
                        }
                        else if (p.GetValue(obj, null) is decimal||p.GetValue(obj,null) is Decimal)
                        {
                            if (!string.IsNullOrEmpty(tb.Text))
                                p.SetValue(obj, Convert.ToDecimal(tb.Text), null);
                            result = true;
                            break;
                        }
                        else if(p.GetValue(obj,null) is int||p.GetValue(obj,null) is Int16)
                        {
                            if (!string.IsNullOrEmpty(tb.Text))
                                p.SetValue(obj, Convert.ToInt16(tb.Text), null);
                            result = true;
                            break;    
                        }
                        else
                        {
                            //if (!string.IsNullOrEmpty(tb.Text))
                                p.SetValue(obj, tb.Text.Trim(), null);
                            result = true;
                            break;
                        }
                    }
                }
                return result;
            }
            catch(Exception ex)
            {
                return false;
            }
            
        }


        /// <summary>
        /// 界面绑定或反向绑定
        /// </summary>
        /// <param name="parentControl">父控件</param>
        /// <param name="obj">对象</param>
        /// <param name="frontStr">录入控件前缀</param>
        /// <param name="isInitObj">true:将文本内容绑定对象；false:对象值绑定控件</param>
        /// <returns></returns>
        public static bool InitDataOrUI(Control parentControl, object obj, string frontStr, bool isInitObj)
        {
            if (obj == null)
                return false;
            return InitDataOrUI(parentControl, obj, frontStr, isInitObj, false);
        }

        public static bool InitDataOrUI(Control parentControl, object obj, string frontStr, bool isInitObj, bool isFindAll)
        {
            if (obj == null)
                return false;
            try
            {
                foreach (Control ct in parentControl.Controls)
                {
                    if (ct is TextBox)
                    {
                        if (isInitObj)
                            SetValFromText(ct as TextBox, obj, frontStr);
                        else
                            SetTextVal(ct as TextBox, obj, frontStr);
                    }
                    else if (isFindAll && ct is GroupBox)
                    {
                        InitDataOrUI(ct, obj, frontStr, isInitObj, true);
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                CommonFunc.WriteErrorLog(ex.StackTrace + " " + ex.Message);
                // throw;);
                return false;
            }
        }


        //public static void Writelog(string str)
        //{
        //    System.Diagnostics.Trace.AutoFlush = true;

        //    new System.Diagnostics.TextWriterTraceListener(AppDomain.CurrentDomain.BaseDirectory + "app.log", "log");
        //    System.Diagnostics.Trace.WriteLine(str);
        //}
        /// <summary>
        /// 重写内容，覆盖原来内容
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="content"></param>
        public static void Writetxt(string content)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"log\" + DateTime.Now.ToString("yyyy-MM-dd") + ".log");
            Writetxt(filePath, content, false);
        }
        /// <summary>
        /// 追加内容
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="lineStr"></param>
        public static void AppendTxt(string lineStr)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"log\"+DateTime.Now.ToString("yyyy-MM-dd") + ".log");
            Writetxt(filePath, lineStr, true);
        }
        public static void Writetxt(string filePath, object o, bool isAppend)
        {
            if(o!=null)
            {
                if(Directory.Exists(Path.GetDirectoryName(filePath))==false)
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(filePath));
                }
                using (StreamWriter sw = new StreamWriter(filePath, isAppend))
                {
                    sw.WriteLine(DateTime.Now.ToString("T")+"  "+o.ToString());
                    sw.Close();
                }
            }
        }


        public static double CaculMidVal(double midData, SortedList parasHastable)
        {
            try
            {
                object a = 0; // = (midData / 10);
                object b = 0; // = a + 10;
                double minVal = 0;
                double maxval = 0;
                foreach (object o in parasHastable.Keys)
                {
                    object flag = o;
                    if (midData == Convert.ToDouble(o))
                        return Convert.ToDouble(parasHastable[o]);
                    if (midData > Convert.ToDouble(o))
                    {
                        if (minVal < Convert.ToDouble(o) || minVal == 0)
                        {
                            minVal = Convert.ToDouble(o);
                            a = flag;
                        }
                    }
                    if (midData < Convert.ToDouble(o))
                    {
                        if (maxval > Convert.ToDouble(o) || maxval == 0)
                        {
                            maxval = Convert.ToDouble(o);
                            b = flag;
                        }
                    }
                }
                if (Convert.ToDouble(b) == 0) //没在列表中找到位置
                    return double.NaN;


                double va = Convert.ToDouble(parasHastable[a]);
                double vb = Convert.ToDouble(parasHastable[b]);
                return GetMidVal(midData, b, a, vb, va);
            }
            catch (Exception ex)
            {
                CommonFunc.WriteErrorLog(ex.StackTrace + " msg " + ex.Message);
                return 0;
            }
            finally
            {
            }
        }
        /// <summary>
        /// 算术内插法
        /// </summary>
        /// <param name="midData">中间参数</param>
        /// <param name="b">中间左侧参数</param>
        /// <param name="a">中间右侧参数</param>
        /// <param name="vb">中间左侧参数值</param>
        /// <param name="va">中间右侧参数值</param>
        /// <returns></returns>
        public static double GetMidVal(double midData, object b, object a, double vb,double va)
        {
            return (va - (va - vb) * (midData - Convert.ToDouble(a)) / ( Convert.ToDouble(b) -  Convert.ToDouble(a)));
        }
        /// <summary>
        /// 华氏度---> 摄氏度
        /// </summary>
        /// <param name="fahrenheitVal"></param>
        /// <returns></returns>
        public static double GetDegree(double fahrenheitVal)
        {
            return (fahrenheitVal - 32)*5/9;
        }
        /// <summary>
        /// 摄氏度---> 华氏度
        /// </summary>
        /// <param name="degreeVal"></param>
        /// <returns></returns>
        public static double GetFahrenheit(double  degreeVal)
        {
            return degreeVal*9/5 + 32;
        }

        /// <summary>  
        /// 分析用户请求是否正常  
        /// </summary>  
        /// <param name="Str">传入用户提交数据</param>  
        /// <returns>返回是否含有SQL注入式攻击代码</returns>  
        public static bool ProcessSqlStr(string Str, int type)
        {
            string SqlStr;

            if (type == 1)
                SqlStr = "exec |insert |select |delete |update |count |chr |mid |master |truncate |char |declare ";
            else
                SqlStr = "'|and|exec|insert|select|delete|update|count|*|chr|mid|master|truncate|char|declare";

            bool ReturnValue = true;
            try
            {
                if (Str != "")
                {
                    string[] anySqlStr = SqlStr.Split('|');
                    foreach (string ss in anySqlStr)
                    {
                        if (Str.IndexOf(ss) >= 0)
                        {
                            ReturnValue = false;
                        }
                    }
                }
            }
            catch
            {
                ReturnValue = false;
            }
            return ReturnValue;
        }
        /// <summary>  
        /// 检测是否有Sql危险字符  
        /// </summary>  
        /// <param name="str">要判断字符串</param>  
        /// <returns>判断结果</returns>  
        public static bool IsSafeSqlString(string str)
        {
            return !Regex.IsMatch(str, @"[|;|,|\/|\(|\)|\[|\]|\}|\{|%|@|\*|!|\']");
        }

        #region 序列化
        public class SaveObj
        {
            public double A1 { get; set; }
            public double A2 { get; set; }
            public subObj s;
            public SaveObj()
            {
                s = new subObj();
            }
        }
        public class subObj
        {
            public double B1 { get; set; }
            public double B2 { get; set; }
        }
        public void Deserialize(string xmlPath)
        {
            SaveObj sj = new SaveObj();
            sj.A1 = 1;
            sj.A2 = 2;
            sj.s.B1 = 3;
            sj.s.B2 = 4;

            //subObj sss=new subObj();
            //sss.B1 = 3;
            //sss.B2 = 4;
            XmlSerializer s = new XmlSerializer(typeof(SaveObj));

            TextWriter w = new StreamWriter(xmlPath);
            //sss = sj.s;
            s.Serialize(w, sj);

            w.Close();
        }
        public void Serialize(string xmlPath)
        {
            SaveObj sj = new SaveObj();
            sj.A1 = 1;
            sj.A2 = 2;
            sj.s.B1 = 3;
            sj.s.B2 = 4;
            XmlSerializer s = new XmlSerializer(typeof(SaveObj));
            TextReader r = new StreamReader(xmlPath);

            SaveObj person2 = (SaveObj)s.Deserialize(r);

            r.Close();
        }
        public void DeserList(string xmlPath)
        {
            SaveObj sj = new SaveObj();
            sj.A1 = 1;
            sj.A2 = 2;
            sj.s.B1 = 3;
            sj.s.B2 = 4;
            List<SaveObj> people = new List<SaveObj>();

            people.Add(sj);
            SaveObj sj2 = new SaveObj();
            sj2.A1 = 1;
            sj2.A2 = 2;
            sj2.s.B1 = 3;
            sj2.s.B2 = 4;
            people.Add(sj2);
            TextWriter w = new StreamWriter(xmlPath);
            XmlSerializer s = new XmlSerializer(typeof(List<SaveObj>));

            s.Serialize(w, people);
            w.Close();
        }
        public void SerializeList(string xmlPath)
        {
            XmlSerializer s = new XmlSerializer(typeof(List<SaveObj>));
            TextReader r = new StreamReader(xmlPath);

            IList<SaveObj> person2 = (IList<SaveObj>)s.Deserialize(r);

            r.Close();
        }
        public void DeserArr(string xmlPath)
        {
            ArrayList people = new ArrayList();

            //people.Add(new Person("abc", "123"));

            //people.Add(new Person("def", "123"));
            SaveObj sj = new SaveObj();
            sj.A1 = 1;
            sj.A2 = 2;
            sj.s.B1 = 3;
            sj.s.B2 = 4;
            //List<SaveObj> people = new List<SaveObj>();

            people.Add(sj);
            SaveObj sj2 = new SaveObj();
            sj2.A1 = 11;
            sj2.A2 = 22;
            sj2.s.B1 = 33;
            sj2.s.B2 = 44;
            people.Add(sj2);
            //你需要告诉系统关于数组的信息

            XmlSerializer s =

                new XmlSerializer(typeof(ArrayList),

                                  new Type[] { typeof(SaveObj) });
            TextWriter w = new StreamWriter(xmlPath);
            s.Serialize(w, people);
            w.Close();
        }
        public void SerializeArr(string xmlPath)
        {


            //XmlSerializer mySerializer = new XmlSerializer(t);
            //StreamReader mem2 = new StreamReader(new MemoryStream(System.Text.Encoding.Default.GetBytes(s)), System.Text.Encoding.Default);
            //return mySerializer.Deserialize(mem2);


            XmlSerializer s = new XmlSerializer(typeof(ArrayList), new Type[] { typeof(SaveObj) });
            TextReader r = new StreamReader(xmlPath);

            ArrayList person2 = (ArrayList)s.Deserialize(r);

            r.Close();
        }
        public ArrayList DeserializeArrayList(string serQuestions, Type type, Type[] extratype)
        {

            XmlSerializer xs = new XmlSerializer(type, extratype);

            StreamReader sr = new StreamReader(new MemoryStream(System.Text.Encoding.Default.GetBytes(serQuestions)),
                                               System.Text.Encoding.Default);

            return (ArrayList)xs.Deserialize(sr);

        }


        #endregion
    }
}
