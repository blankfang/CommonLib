using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace CommonLib
{
    public class DBLibHelp
    {
        public enum DB_Type
        {
            SQLServer,
            Oracle,
            Access
        }
        public enum Manual_Type
        {
            Insert,
            Update,
            Delete
        }
        public DBLibHelp()
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="valueObj"></param>
        /// <param name="dbType">0:SQL;1:Oracle;2:Access</param>
        /// <returns></returns>
        public static Hashtable GenParasHash(object valueObj, DB_Type dbType, Manual_Type manualType, out string outstr)
        {

            return setPara(valueObj, dbType, manualType, out outstr);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="valueObj"></param>
        /// <param name="dbType">0:SQL;1:Oracle;2:Access</param>
        /// <returns></returns>
        private static Hashtable setPara(object valueObj, DB_Type dbType, Manual_Type manualType, out string fieldStr)
        {
            string flag = ":";
            if (dbType == DB_Type.SQLServer || dbType == DB_Type.Access)
                flag = "@";
            fieldStr = "";
            string vals = "";
            Hashtable result = new Hashtable();
            int i = 0;
            foreach (PropertyInfo p in valueObj.GetType().GetProperties())
            {
                if (getObjValue(p.Name, valueObj) != null)
                {
                    result.Add(flag + p.Name, getObjValue(p.Name, valueObj));
                    if (i == 0)
                    {
                        i++;
                    }
                    else
                    {
                        fieldStr += ",";
                        vals += ",";
                    }
                    if (manualType == Manual_Type.Insert)
                    {
                        vals += p.Name;
                        fieldStr += flag + p.Name;
                    }
                    else if (manualType == Manual_Type.Update)
                    {
                        fieldStr += " " + p.Name + "=" + flag + p.Name;
                    }
                }
            }
            if (dbType == DB_Type.Access)
            {
                vals = "";
                fieldStr = "";
                int j = 0;
                foreach (string str in result.Keys)
                {
                    if (j == 0)
                    {
                        j++;
                    }
                    else
                    {
                        fieldStr += ",";
                        vals += ",";
                    }
                    if (manualType == Manual_Type.Insert)
                    {
                        vals += str.Replace(flag, "");
                        fieldStr += str;
                    }
                    else if (manualType == Manual_Type.Update)
                    {
                        fieldStr += " " + str.Replace(flag, "") + "=" + str;
                    }
                }
            }
            if (manualType == Manual_Type.Insert)
                fieldStr = "(" + vals + ") values (" + fieldStr + ") ";
            return result;
        }

        private static object getObjValue(string attName, object obj)
        {
            PropertyInfo p = obj.GetType().GetProperty(attName);
            if (p != null)
                p.GetValue(obj, null);

            return obj;
        }

        public static object SetObjVal(object obj, System.Data.IDataRecord reader)
        {
            System.Reflection.PropertyInfo[] pcollections = obj.GetType().GetProperties();
            foreach (System.Reflection.PropertyInfo p in pcollections)
            {
                try
                {
                    if (reader[p.Name] != null)
                    {
                        if (string.IsNullOrEmpty(reader[p.Name].ToString()))
                            continue;
                        try
                        {

                            Type tempType = p.PropertyType;
                            if (tempType.Name == "Nullable`1")
                                tempType = Nullable.GetUnderlyingType(tempType);
                            if (tempType.Name == "Char[]")
                            {
                                p.SetValue(obj, reader[p.Name].ToString().ToCharArray(), null);
                                continue;
                            }
                            p.SetValue(obj, Convert.ChangeType(reader[p.Name], tempType), null);

                        }
                        catch (Exception ex)
                        {
                            CommonFunc.WriteErrorLog("SoruceDataLogic_setObj CRHASH1:" + ex.Message);
                            continue;
                        }
                    }
                }
                catch (Exception ex)
                {
                    CommonFunc.WriteErrorLog("SoruceDataLogic_setObj2 CRHASH2:" + p.Name + " " + ex.Message);
                    continue;
                }
            }
            return obj;
        }

        /// <summary>
        /// DataRow赋值给实体类对象
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="reader">DataRow赋值给实体类对象</param>
        /// <returns></returns>
        public static object SetObjVal(object obj, System.Data.DataRow reader)
        {
            System.Reflection.PropertyInfo[] pcollections = obj.GetType().GetProperties();
            foreach (System.Reflection.PropertyInfo p in pcollections)
            {
                try
                {
                    if (reader[p.Name] != null)
                    {
                        if (string.IsNullOrEmpty(reader[p.Name].ToString()))
                            continue;

                        Type tempType = p.PropertyType;
                        if (tempType.Name == "Nullable`1")
                            tempType = Nullable.GetUnderlyingType(tempType);

                        if (tempType.Name == "Char[]")
                        {
                            p.SetValue(obj, reader[p.Name].ToString().ToCharArray(), null);
                            continue;
                        }
                        p.SetValue(obj, Convert.ChangeType(reader[p.Name], tempType), null);
                    }
                }
                catch (Exception ex)
                {
                    CommonFunc.WriteErrorLog("SoruceDataLogic_setObj DataRow:" + p.Name + " " + ex.Message);
                    continue;
                }
            }
            return obj;
        }

        public static string GenSplitPageSQL(string sourceSql, int nPage, int PageSize)
        {

            int startIndex = nPage * PageSize - PageSize;
            int endIndex = startIndex + PageSize;
            return
                "select sTb.* from (SELECT ROWNUM R,sTb.* from(" + sourceSql + ")" +
                " sTb where rownum <= " + endIndex + ")sTb where " +
                "sTb.R >" + startIndex;
        }
          
    }
}
