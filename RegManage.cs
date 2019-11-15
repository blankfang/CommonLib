using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;

namespace CommonLib
{
   public class RegManage
    {
        private static RegManage _instance;
       private const string compRegKey = "keqia";
        public static RegManage Instance
        {
            get { return _instance ?? (_instance = new RegManage()); }
        }
        private RegManage()
        {

        }
        /// <summary>
        /// 读取的注册表中HKEY_LOCAL_MACHINE\SOFTWARE目录下的XXX目录中名称为name的注册表值；
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public string GetRegistData(string name)
        {
            string registData;
            RegistryKey hkml = Registry.LocalMachine;
            RegistryKey software = hkml.OpenSubKey("SOFTWARE", true);
            RegistryKey aimdir = software.OpenSubKey(compRegKey, true);
            registData = aimdir.GetValue(name).ToString();
            return registData;
        }
        /// <summary>
        /// 注册表中HKEY_LOCAL_MACHINE\SOFTWARE目录下新建XXX目录并在此目录下创建名称为name值为tovalue的注册表项
        /// </summary>
        /// <param name="name"></param>
        /// <param name="tovalue"></param>
        public void AddRegistData(string name, string tovalue)
        {
            RegistryKey hklm = Registry.LocalMachine;
            RegistryKey software = hklm.OpenSubKey("SOFTWARE", true);
            RegistryKey aimdir = software.CreateSubKey(compRegKey);
            aimdir.SetValue(name, tovalue);
        }
        /// <summary>
        /// 在注册表中HKEY_LOCAL_MACHINE\SOFTWARE目录下XXX目录中删除名称为name注册表项
        /// </summary>
        /// <param name="name"></param>
        public void DeleteRegItem(string name)
        {
            string[] aimnames;
            RegistryKey hkml = Registry.LocalMachine;
            RegistryKey software = hkml.OpenSubKey("SOFTWARE", true);
            RegistryKey aimdir = software.OpenSubKey(compRegKey, true);
            aimnames = aimdir.GetSubKeyNames();
            foreach (string aimKey in aimnames)
            {
                if (aimKey == name)
                    aimdir.DeleteSubKeyTree(name);
            }
        }
        /// <summary>
        /// 在注册表中HKEY_LOCAL_MACHINE\SOFTWARE目录下XXX目录中判断名称为name注册表项是否存在
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool IsRegExitItem(string name)
        {
            bool _exit = false;
            string[] subkeyNames;
            RegistryKey hkml = Registry.LocalMachine;
            RegistryKey software = hkml.OpenSubKey("SOFTWARE", true);
            RegistryKey aimdir = software.OpenSubKey(compRegKey, true);
            if(aimdir==null)
                return false;

            subkeyNames = aimdir.GetValueNames();// get.GetSubKeyNames();
            foreach (string keyName in subkeyNames)
            {
                if (keyName == name)
                {
                    _exit = true;
                    return _exit;
                }
            }
            return _exit;
        }

    }
}
