using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace CommonLib
{
    /// <summary>
    /// 除氧瞬态计算图表配置
    /// </summary>
    public class CyCalChartCfg
    {
        private static CyCalChartCfg _instance;
        public static CyCalChartCfg Instance
        {
            get
            {
                if (_instance == null)
                    Deserialize();
                return _instance;
            }
        }
        public CfgManageClass cfg0;
        public CfgManageClass cfg1;
        public CfgManageClass cfg2;
        public CfgManageClass cfg3;
        public CfgManageClass cfg4;
        
        private static string cfgPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"config\chart\CyCalCharCfg.xml");
        private CyCalChartCfg()
        {
            cfg0 = new CfgManageClass();
            cfg1 = new CfgManageClass();
            cfg2 = new CfgManageClass();
            cfg3 = new CfgManageClass();
            cfg4 = new CfgManageClass();
            
        }
        /// <summary>
        /// LOAD
        /// </summary>
        /// <param name="xmlPath"></param>
        /// <returns></returns>
        private static CyCalChartCfg Deserialize()
        {
            if (File.Exists(cfgPath))
            {
                XmlSerializer s = new XmlSerializer(typeof(CyCalChartCfg));
                using (TextReader r = new StreamReader(cfgPath))
                {
                    _instance = (CyCalChartCfg)s.Deserialize(r);
                    r.Close();
                }
            }
            else
            {
                _instance = new CyCalChartCfg();
            }
            return _instance;

        }

        /// <summary>
        /// SAVE
        /// </summary>
        /// <param name="xmlPath"></param>
        public void Serialize()
        {
            if (File.Exists(cfgPath))
                File.Delete(cfgPath);
            XmlSerializer s = new XmlSerializer(typeof(CyCalChartCfg));
            using (TextWriter w = new StreamWriter(cfgPath))
            {
                s.Serialize(w, this);
                w.Close();
            }
        }
    }
    /// <summary>
    /// 冷端图表配置
    /// </summary>
    public class CoolChartCfg
    {
        private static CoolChartCfg _instance;
        public static CoolChartCfg Instance
        {
            get
            {
                if (_instance == null)
                    Deserialize();
                return _instance;
            }
        }
        public CfgManageClass cfg0;
        public CfgManageClass cfg1;
        public CfgManageClass cfg2;
        public CfgManageClass cfg3;
        public CfgManageClass cfg4;
        public CfgManageClass cfg5;
        private static string cfgPath =Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"config\chart\CoolCharCfg.xml");
        private CoolChartCfg()
        {
            if (!System.IO.Directory.Exists(cfgPath))
                System.IO.Directory.CreateDirectory(System.IO.Path.GetDirectoryName(cfgPath));

            cfg0 = new CfgManageClass();
            cfg1 = new CfgManageClass();
            cfg2 = new CfgManageClass();
            cfg3 = new CfgManageClass();
            cfg4 = new CfgManageClass();
            cfg5 = new CfgManageClass();
        }
        /// <summary>
        /// LOAD
        /// </summary>
        /// <param name="xmlPath"></param>
        /// <returns></returns>
        private static CoolChartCfg Deserialize()
        {
            if (File.Exists(cfgPath))
            {
                XmlSerializer s = new XmlSerializer(typeof (CoolChartCfg));
                using (TextReader r = new StreamReader(cfgPath))
                {
                    _instance = (CoolChartCfg)s.Deserialize(r);
                    r.Close();
                }
            }
            else
            {
                _instance=new CoolChartCfg();
            }
            return _instance;

        }

        /// <summary>
        /// SAVE
        /// </summary>
        /// <param name="xmlPath"></param>
        public void Serialize()
        {
            if (File.Exists(cfgPath))
                File.Delete(cfgPath);
            XmlSerializer s = new XmlSerializer(typeof(CoolChartCfg));
            using (TextWriter w = new StreamWriter(cfgPath))
            {
                s.Serialize(w, this);
                w.Close();
            }
        }
    }
    /// <summary>
    /// APA图表配置
    /// </summary>
    public class ApaChartCfg
    {
        private static ApaChartCfg _instance;
        public static ApaChartCfg Instance
        {
            get
            {
                if (_instance == null)
                    Deserialize();
                return _instance;
            }
        }
        public CfgManageClass cfg0;
        public CfgManageClass cfg1;
        public CfgManageClass cfg2;
        private static string cfgPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"config\chart\APACharCfg.xml");
        private ApaChartCfg()
        {
            if (!System.IO.Directory.Exists(cfgPath))
                System.IO.Directory.CreateDirectory(System.IO.Path.GetDirectoryName(cfgPath));

            cfg0 = new CfgManageClass();
            cfg1 = new CfgManageClass();
            cfg2 = new CfgManageClass();
        }
        /// <summary>
        /// LOAD
        /// </summary>
        /// <param name="xmlPath"></param>
        /// <returns></returns>
        private static ApaChartCfg Deserialize()
        {
            if (File.Exists(cfgPath))
            {
                XmlSerializer s = new XmlSerializer(typeof(ApaChartCfg));
                using (TextReader r = new StreamReader(cfgPath))
                {
                    _instance = (ApaChartCfg)s.Deserialize(r);
                    r.Close();
                }
            }
            else
            {
                _instance = new ApaChartCfg();
            }
            return _instance;

        }

        /// <summary>
        /// SAVE
        /// </summary>
        /// <param name="xmlPath"></param>
        public void Serialize()
        {
            if (File.Exists(cfgPath))
                File.Delete(cfgPath);
            XmlSerializer s = new XmlSerializer(typeof(ApaChartCfg));
            using (TextWriter w = new StreamWriter(cfgPath))
            {
                s.Serialize(w, this);
                w.Close();
            }
        }
    }
    public class CfgManageClass
    {
        public double XMax { get; set; }
        public double XMin { get; set; }

        public double YMax { get; set; }
        public double YMin { get; set; }

        public double XStep { get; set; }
        public double YStep { get; set; }

        public int StyleIndex { get; set; }
        public int ColorIndex { get; set; }
    }
}
