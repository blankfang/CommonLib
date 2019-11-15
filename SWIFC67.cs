using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CommonLib
{
    /*
   根据IFC67编写的动态链接库的函数的调用接口声明
    专供Borland C# Builder (C#语言) 使用

    使用方法：

    直接把本软件包提供的类文件(SWIFC67.cs)加进对应项目，
    在需要调用函数的单元中引用本类文件的命名空间(using SWIF97IFC67)即可！

    把类文件(SWIFC67.cs)包括进入项目的菜单路径为：
        [Project]|[Add to Project... Shift+F11]

    在需要调用函数的单元中引用本类文件的命名空间(using SWIF97IFC67)时无菜单路径，需手工输入！
*/
    public class SWIFC67
    {
        //动态连接库中函数的声明
        //C#中的声明

        //已知压力(MPa)，求对应饱和温度(℃)
        [DllImport("IFC67", EntryPoint = "P2T67")]
        public static extern void P2T67(double P, ref double T, ref int Range);
        //已知压力(MPa)，求对应饱和水比焓(kJ/kg)
        [DllImport("IFC67", EntryPoint = "P2HL67")]
        public static extern void P2HL67(double P, ref double H, ref int Range);
        //已知压力(MPa)，求对应饱和汽比焓(kJ/kg)
        [DllImport("IFC67", EntryPoint = "P2HG67")]
        public static extern void P2HG67(double P, ref double H, ref int Range);
        //已知压力(MPa)，求对应饱和水比熵(kJ/(kg.℃))
        [DllImport("IFC67", EntryPoint = "P2SL67")]
        public static extern void P2SL67(double P, ref double S, ref int Range);
        //已知压力(MPa)，求对应饱和汽比熵(kJ/(kg.℃))
        [DllImport("IFC67", EntryPoint = "P2SG67")]
        public static extern void P2SG67(double P, ref double S, ref int Range);
        //已知压力(MPa)，求对应饱和水比容(m^3/kg)
        [DllImport("IFC67", EntryPoint = "P2VL67")]
        public static extern void P2VL67(double P, ref double V, ref int Range);
        //已知压力(MPa)，求对应饱和汽比容(m^3/kg)
        [DllImport("IFC67", EntryPoint = "P2VL67")]
        public static extern void P2VG67(double P, ref double V, ref int Range);
        //已知压力(MPa)，求对应饱和温度(℃)、饱和水比焓(kJ/kg)、饱和水比熵(kJ/(kg.℃))、饱和水比容(m^3/kg)
        [DllImport("IFC67", EntryPoint = "P2L67")]
        public static extern void P2L67(double P, ref double T, ref double H, ref double S, ref double V, ref double X, ref int Range);
        //已知压力(MPa)，求对应饱和温度(℃)、饱和汽比焓(kJ/kg)、饱和汽比熵(kJ/(kg.℃))、饱和汽比容(m^3/kg)
        [DllImport("IFC67", EntryPoint = "P2G67")]
        public static extern void P2G67(double P, ref double T, ref double H, ref double S, ref double V, ref double X, ref int Range);
        //已知压力(MPa)，求对应饱和水定压比热(kJ/(kg.℃))
        [DllImport("IFC67", EntryPoint = "P2CPL67")]
        public static extern void P2CPL67(double P, ref double CP, ref int Range);
        //已知压力(MPa)，求对应饱和汽定压比热(kJ/(kg.℃))
        [DllImport("IFC67", EntryPoint = "P2CPG67")]
        public static extern void P2CPG67(double P, ref double CP, ref int Range);
        //已知压力(MPa)，求对应饱和水定容比热(kJ/(kg.℃))
        [DllImport("IFC67", EntryPoint = "P2CVL67")]
        public static extern void P2CVL67(double P, ref double CV, ref int Range);
        //已知压力(MPa)，求对应饱和汽定容比热(kJ/(kg.℃))
        [DllImport("IFC67", EntryPoint = "P2CVG67")]
        public static extern void P2CVG67(double P, ref double CV, ref int Range);
        //已知压力(MPa)，求对应饱和水内能(kJ/kg)
        [DllImport("IFC67", EntryPoint = "P2EL67")]
        public static extern void P2EL67(double P, ref double E, ref int Range);
        //已知压力(MPa)，求对应饱和汽内能(kJ/kg)
        [DllImport("IFC67", EntryPoint = "P2EG67")]
        public static extern void P2EG67(double P, ref double E, ref int Range);
        //已知压力(MPa)，求对应饱和水音速(m/s)
        [DllImport("IFC67", EntryPoint = "P2SSPL67")]
        public static extern void P2SSPL67(double P, ref double SSP, ref int Range);
        //已知压力(MPa)，求对应饱和汽音速(m/s)
        [DllImport("IFC67", EntryPoint = "P2SSPG67")]
        public static extern void P2SSPG67(double P, ref double SSP, ref int Range);
        //已知压力(MPa)，求对应饱和水定熵指数
        [DllImport("IFC67", EntryPoint = "P2KSL67")]
        public static extern void P2KSL67(double P, ref double KS, ref int Range);
        //已知压力(MPa)，求对应饱和汽定熵指数
        [DllImport("IFC67", EntryPoint = "P2KSG67")]
        public static extern void P2KSG67(double P, ref double KS, ref int Range);
        //已知压力(MPa)，求对应饱和水动力粘度(Pa.s)
        [DllImport("IFC67", EntryPoint = "P2ETAL67")]
        public static extern void P2ETAL67(double P, ref double ETA, ref int Range);
        //已知压力(MPa)，求对应饱和汽动力粘度(Pa.s)
        [DllImport("IFC67", EntryPoint = "P2ETAG67")]
        public static extern void P2ETAG67(double P, ref double ETA, ref int Range);
        //已知压力(MPa)，求对应饱和水运动粘度(m^2/s)
        [DllImport("IFC67", EntryPoint = "P2UL67")]
        public static extern void P2UL67(double P, ref double U, ref int Range);
        //已知压力(MPa)，求对应饱和汽运动粘度(m^2/s)
        [DllImport("IFC67", EntryPoint = "P2UG67")]
        public static extern void P2UG67(double P, ref double U, ref int Range);
        //已知压力(MPa)，求对应饱和水导热系数(W/(m.℃))
        [DllImport("IFC67", EntryPoint = "P2RAMDL67")]
        public static extern void P2RAMDL67(double P, ref double RAMD, ref int Range);
        //已知压力(MPa)，求对应饱和汽导热系数(W/(m.℃))
        [DllImport("IFC67", EntryPoint = "P2RAMDG67")]
        public static extern void P2RAMDG67(double P, ref double RAMD, ref int Range);
        //已知压力(MPa)，求对应饱和水普朗特数
        [DllImport("IFC67", EntryPoint = "P2PRNL67")]
        public static extern void P2PRNL67(double P, ref double PRN, ref int Range);
        //已知压力(MPa)，求对应饱和汽普朗特数
        [DllImport("IFC67", EntryPoint = "P2PRNG67")]
        public static extern void P2PRNG67(double P, ref double PRN, ref int Range);
        //已知压力(MPa)，求对应饱和水介电常数
        [DllImport("IFC67", EntryPoint = "P2EPSL67")]
        public static extern void P2EPSL67(double P, ref double EPS, ref int Range);
        //已知压力(MPa)，求对应饱和汽介电常数
        [DllImport("IFC67", EntryPoint = "P2EPSG67")]
        public static extern void P2EPSG67(double P, ref double EPS, ref int Range);
        //已知压力(MPa)，求对应饱和水折射率
        [DllImport("IFC67", EntryPoint = "P2NL67")]
        public static extern void P2NL67(double P, double LAMD, ref double N, ref int Range);
        //已知压力(MPa)，求对应饱和汽折射率
        [DllImport("IFC67", EntryPoint = "P2NG67")]
        public static extern void P2NG67(double P, double LAMD, ref double N, ref int Range);

        //已知压力(MPa)和温度(℃)，求比焓(kJ/kg)
        [DllImport("IFC67", EntryPoint = "PT2H67")]
        public static extern void PT2H67(double P, double T, ref double H, ref int Range);
        //已知压力(MPa)和温度(℃)，求比熵(kJ/(kg.℃))
        [DllImport("IFC67", EntryPoint = "PT2S67")]
        public static extern void PT2S67(double P, double T, ref double S, ref int Range);
        //已知压力(MPa)和温度(℃)，求比容(m^3/kg)
        [DllImport("IFC67", EntryPoint = "PT2V67")]
        public static extern void PT2V67(double P, double T, ref double V, ref int Range);
        //已知压力(MPa)和温度(℃)，求干度(100%)
        [DllImport("IFC67", EntryPoint = "PT2X67")]
        public static extern void PT2X67(double P, double T, ref double X, ref int Range);
        //已知压力(MPa)和温度(℃)，求比焓(kJ/kg)、比熵(kJ/(kg.℃))、比容(m^3/kg)
        [DllImport("IFC67", EntryPoint = "PT67")]
        public static extern void PT67(double P, double T, ref double H, ref double S, ref double V, ref double X, ref int Range);
        //已知压力(MPa)和温度(℃)，求定压比热(kJ/(kg.℃))
        [DllImport("IFC67", EntryPoint = "PT2CP67")]
        public static extern void PT2CP67(double P, double T, ref double CP, ref int Range);
        //已知压力(MPa)和温度(℃)，求定容比热(kJ/(kg.℃))
        [DllImport("IFC67", EntryPoint = "PT2CV67")]
        public static extern void PT2CV67(double P, double T, ref double CV, ref int Range);
        //已知压力(MPa)和温度(℃)，求内能(kJ/kg)
        [DllImport("IFC67", EntryPoint = "PT2E67")]
        public static extern void PT2E67(double P, double T, ref double E, ref int Range);
        //已知压力(MPa)和温度(℃)，求音速(m/s)
        [DllImport("IFC67", EntryPoint = "PT2SSP67")]
        public static extern void PT2SSP67(double P, double T, ref double SSP, ref int Range);
        //已知压力(MPa)和温度(℃)，求定熵指数
        [DllImport("IFC67", EntryPoint = "PT2KS67")]
        public static extern void PT2KS67(double P, double T, ref double KS, ref int Range);
        //已知压力(MPa)和温度(℃)，求动力粘度(Pa.s)
        [DllImport("IFC67", EntryPoint = "PT2ETA67")]
        public static extern void PT2ETA67(double P, double T, ref double ETA, ref int Range);
        //已知压力(MPa)和温度(℃)，求运动粘度(m^2/s)
        [DllImport("IFC67", EntryPoint = "PT2U67")]
        public static extern void PT2U67(double P, double T, ref double U, ref int Range);
        //已知压力(MPa)和温度(℃)，求热传导系数 (W/(m.℃))
        [DllImport("IFC67", EntryPoint = "PT2RAMD67")]
        public static extern void PT2RAMD67(double P, double T, ref double RAMD, ref int Range);
        //已知压力(MPa)和温度(℃)，求普朗特数
        [DllImport("IFC67", EntryPoint = "PT2PRN67")]
        public static extern void PT2PRN67(double P, double T, ref double PRN, ref int Range);
        //已知压力(MPa)和温度(℃)，求介电常数
        [DllImport("IFC67", EntryPoint = "PT2EPS67")]
        public static extern void PT2EPS67(double P, double T, ref double EPS, ref int Range);
        //已知压力(MPa)和温度(℃)，求折射率
        [DllImport("IFC67", EntryPoint = "PT2N67")]
        public static extern void PT2N67(double P, double T, double LAMD, ref double N, ref int Range);

        //已知压力(MPa)和比焓(kJ/kg)，求温度(℃)
        [DllImport("IFC67", EntryPoint = "PH2T67")]
        public static extern void PH2T67(double P, double H, ref double T, ref int Range);
        //已知压力(MPa)和比焓(kJ/kg)，求比熵(kJ/(kg.℃))
        [DllImport("IFC67", EntryPoint = "PH2S67")]
        public static extern void PH2S67(double P, double H, ref double S, ref int Range);
        //已知压力(MPa)和比焓(kJ/kg)，求比容(m^3/kg)
        [DllImport("IFC67", EntryPoint = "PH2V67")]
        public static extern void PH2V67(double P, double H, ref double V, ref int Range);
        //已知压力(MPa)和比焓(kJ/kg)，求干度(100%)
        [DllImport("IFC67", EntryPoint = "PH2X67")]
        public static extern void PH2X67(double P, double H, ref double X, ref int Range);
        //已知压力(MPa)和比焓(kJ/kg)，求温度(℃)、比熵(kJ/(kg.℃))、比容(m^3/kg)、干度(100%)
        [DllImport("IFC67", EntryPoint = "PH67")]
        public static extern void PH67(double P, ref double T, double H, ref double S, ref double V, ref double X, ref int Range);

        //已知压力(MPa)和比熵(kJ/(kg.℃))，求温度(℃)
        [DllImport("IFC67", EntryPoint = "PS2T67")]
        public static extern void PS2T67(double P, double S, ref double T, ref int Range);
        //已知压力(MPa)和比熵(kJ/(kg.℃))，求比焓(kJ/kg)
        [DllImport("IFC67", EntryPoint = "PS2H67")]
        public static extern void PS2H67(double P, double S, ref double H, ref int Range);
        //已知压力(MPa)和比熵(kJ/(kg.℃))，求比容(m^3/kg)
        [DllImport("IFC67", EntryPoint = "PS2V67")]
        public static extern void PS2V67(double P, double S, ref double V, ref int Range);
        //已知压力(MPa)和比熵(kJ/(kg.℃))，求干度(100%)
        [DllImport("IFC67", EntryPoint = "PS2TX7")]
        public static extern void PS2X67(double P, double S, ref double X, ref int Range);
        //已知压力(MPa)和比熵(kJ/(kg.℃))，求温度(℃)、比焓(kJ/kg)、比容(m^3/kg)、干度(100%)
        [DllImport("IFC67", EntryPoint = "PS67")]
        public static extern void PS67(double P, ref double T, ref double H, double S, ref double V, ref double X, ref int Range);

        //已知压力(MPa)和比容(m^3/kg)，求温度(℃)
        [DllImport("IFC67", EntryPoint = "PV2T67")]
        public static extern void PV2T67(double P, double V, ref double T, ref int Range);
        //已知压力(MPa)和比容(m^3/kg)，求比焓(kJ/kg)
        [DllImport("IFC67", EntryPoint = "PV2H67")]
        public static extern void PV2H67(double P, double V, ref double H, ref int Range);
        //已知压力(MPa)和比容(m^3/kg)，求比容(m^3/kg)
        [DllImport("IFC67", EntryPoint = "PV2S67")]
        public static extern void PV2S67(double P, double V, ref double S, ref int Range);
        //已知压力(MPa)和比容(m^3/kg)，求干度(100%)
        [DllImport("IFC67", EntryPoint = "PV2X67")]
        public static extern void PV2X67(double P, double V, ref double X, ref int Range);
        //已知压力(MPa)和比容(m^3/kg)，求温度(℃)、比焓(kJ/kg)、比容(m^3/kg)、干度(100%)
        [DllImport("IFC67", EntryPoint = "PV67")]
        public static extern void PV67(double P, ref double T, ref double H, ref double S, double V, ref double X, ref int Range);

        //已知压力(MPa)和干度(100%)，求温度(℃)
        [DllImport("IFC67", EntryPoint = "PX2T67")]
        public static extern void PX2T67(double P, double X, ref double T, ref int Range);
        //已知压力(MPa)和干度(100%)，求比焓(kJ/kg)
        [DllImport("IFC67", EntryPoint = "PX2H67")]
        public static extern void PX2H67(double P, double X, ref double H, ref int Range);
        //已知压力(MPa)和干度(100%)，求比熵(kJ/(kg.℃))
        [DllImport("IFC67", EntryPoint = "PX2S67")]
        public static extern void PX2S67(double P, double X, ref double S, ref int Range);
        //已知压力(MPa)和干度(100%)，求比容(m^3/kg)
        [DllImport("IFC67", EntryPoint = "PX2V67")]
        public static extern void PX2V67(double P, double X, ref double V, ref int Range);
        //已知压力(MPa)和干度(100%)，求温度(℃)、比焓(kJ/kg)、比熵(kJ/(kg.℃))、比容(m^3/kg)
        [DllImport("IFC67", EntryPoint = "PX67")]
        public static extern void PX67(double P, ref double T, ref double H, ref double S, ref double V, double X, ref int Range);

        //已知温度(℃)，求饱和压力(MPa)？
        [DllImport("IFC67", EntryPoint = "T2P67")]
        public static extern void T2P67(double T, ref double P, ref int Range);
        //已知温度(℃)，求饱和水比焓(kJ/kg)
        [DllImport("IFC67", EntryPoint = "T2HL67")]
        public static extern void T2HL67(double T, ref double H, ref int Range);
        //已知温度(℃)，求饱和汽比焓(kJ/kg)
        [DllImport("IFC67", EntryPoint = "T2HG67")]
        public static extern void T2HG67(double T, ref double H, ref int Range);
        //已知温度(℃)，求饱和水比熵(kJ/(kg.℃))
        [DllImport("IFC67", EntryPoint = "T2SL67")]
        public static extern void T2SL67(double T, ref double S, ref int Range);
        //已知温度(℃)，求饱和汽比熵(kJ/(kg.℃))
        [DllImport("IFC67", EntryPoint = "T2SG67")]
        public static extern void T2SG67(double T, ref double S, ref int Range);
        //已知温度(℃)，求饱和水比容(m^3/kg)
        [DllImport("IFC67", EntryPoint = "T2VL67")]
        public static extern void T2VL67(double T, ref double V, ref int Range);
        //已知温度(℃)，求饱和汽比容(m^3/kg)
        [DllImport("IFC67", EntryPoint = "T2VG67")]
        public static extern void T2VG67(double T, ref double V, ref int Range);
        //已知温度(℃)，求饱和水比焓(kJ/kg)、饱和水比熵(kJ/(kg.℃))、饱和水比容(m^3/kg)
        [DllImport("IFC67", EntryPoint = "T2L67")]
        public static extern void T2L67(ref double P, double T, ref double V, ref int Range);
        //已知温度(℃)，求饱和汽比焓(kJ/kg)、饱和汽比熵(kJ/(kg.℃))、饱和汽比容(m^3/kg)
        [DllImport("IFC67", EntryPoint = "T2G67")]
        public static extern void T2G67(ref double P, double T, ref double V, ref int Range);
        //已知温度(℃)，求饱和水定压比热(kJ/(kg.℃))
        [DllImport("IFC67", EntryPoint = "T2CPL67")]
        public static extern void T2CPL67(double T, ref double CP, ref int Range);
        //已知温度(℃)，求饱和汽定压比热(kJ/(kg.℃))
        [DllImport("IFC67", EntryPoint = "T2CPL67")]
        public static extern void T2CPG67(double T, ref double CP, ref int Range);
        //已知温度(℃)，求饱和水定容比热(kJ/(kg.℃))
        [DllImport("IFC67", EntryPoint = "T2CVL67")]
        public static extern void T2CVL67(double T, ref double CV, ref int Range);
        //已知温度(℃)，求饱和汽定容比热(kJ/(kg.℃))
        [DllImport("IFC67", EntryPoint = "T2CVG67")]
        public static extern void T2CVG67(double T, ref double CV, ref int Range);
        //已知温度(℃)，求饱和水内能(kJ/kg)
        [DllImport("IFC67", EntryPoint = "T2EL67")]
        public static extern void T2EL67(double T, ref double E, ref int Range);
        //已知温度(℃)，求饱和汽内能(kJ/kg)
        [DllImport("IFC67", EntryPoint = "T2EG67")]
        public static extern void T2EG67(double T, ref double E, ref int Range);
        //已知温度(℃)，求饱和水音速(m/s)
        [DllImport("IFC67", EntryPoint = "T2SSPL67")]
        public static extern void T2SSPL67(double T, ref double SSP, ref int Range);
        //已知温度(℃)，求饱和汽音速(m/s)
        [DllImport("IFC67", EntryPoint = "T2SSPG67")]
        public static extern void T2SSPG67(double T, ref double SSP, ref int Range);
        //已知温度(℃)，求饱和水定熵指数
        [DllImport("IFC67", EntryPoint = "T2KSL67")]
        public static extern void T2KSL67(double T, ref double KS, ref int Range);
        //已知温度(℃)，求饱和汽定熵指数
        [DllImport("IFC67", EntryPoint = "T2KSG67")]
        public static extern void T2KSG67(double T, ref double KS, ref int Range);
        //已知温度(℃)，求饱和水动力粘度(Pa.s)
        [DllImport("IFC67", EntryPoint = "T2ETAL67")]
        public static extern void T2ETAL67(double T, ref double ETA, ref int Range);
        //已知温度(℃)，求饱和汽动力粘度(Pa.s)
        [DllImport("IFC67", EntryPoint = "T2ETAG67")]
        public static extern void T2ETAG67(double T, ref double ETA, ref int Range);
        //已知温度(℃)，求饱和水运动粘度(m^2/s)
        [DllImport("IFC67", EntryPoint = "T2UL67")]
        public static extern void T2UL67(double T, ref double U, ref int Range);
        //已知温度(℃)，求饱和汽运动粘度(m^2/s)
        [DllImport("IFC67", EntryPoint = "T2UG67")]
        public static extern void T2UG67(double T, ref double U, ref int Range);
        //已知温度(℃)，求饱和水导热系数(W/(m.℃))
        [DllImport("IFC67", EntryPoint = "T2RAMDL67")]
        public static extern void T2RAMDL67(double T, ref double RAMD, ref int Range);
        //已知温度(℃)，求饱和汽导热系数(W/(m.℃))
        [DllImport("IFC67", EntryPoint = "T2RAMDG67")]
        public static extern void T2RAMDG67(double T, ref double RAMD, ref int Range);
        //已知温度(℃)，求饱和水普朗特数
        [DllImport("IFC67", EntryPoint = "T2PRNL67")]
        public static extern void T2PRNL67(double T, ref double PRN, ref int Range);
        //已知温度(℃)，求饱和汽普朗特数
        [DllImport("IFC67", EntryPoint = "T2PRNG67")]
        public static extern void T2PRNG67(double T, ref double PRN, ref int Range);
        //已知温度(℃)，求饱和水介电常数
        [DllImport("IFC67", EntryPoint = "T2EPSL67")]
        public static extern void T2EPSL67(double T, ref double EPS, ref int Range);
        //已知温度(℃)，求饱和汽介电常数
        [DllImport("IFC67", EntryPoint = "T2EPSG67")]
        public static extern void T2EPSG67(double T, ref double EPS, ref int Range);
        //已知温度(℃)，求饱和水折射率
        [DllImport("IFC67", EntryPoint = "T2NL67")]
        public static extern void T2NL67(double T, double LAMD, ref double N, ref int Range);
        //已知温度(℃)，求饱和汽折射率
        [DllImport("IFC67", EntryPoint = "T2NG67")]
        public static extern void T2NG67(double T, double LAMD, ref double N, ref int Range);
        //已知温度(℃)，求饱和水表面张力(N/m)
        [DllImport("IFC67", EntryPoint = "T2SURFT67")]
        public static extern void T2SURFT67(double T, ref double SURFT, ref int Range);

        //已知温度(℃)和比焓(kJ/kg)，求压力(MPa)(低压的一个值)
        [DllImport("IFC67", EntryPoint = "TH2PLP67")]
        public static extern void TH2PLP67(double T, double H, ref double P, ref int Range);
        //已知温度(℃)和比焓(kJ/kg)，求比熵(kJ/(kg.℃))(低压的一个值)
        [DllImport("IFC67", EntryPoint = "TH2SLP67")]
        public static extern void TH2SLP67(double T, double H, ref double S, ref int Range);
        //已知温度(℃)和比焓(kJ/kg)，求比容(m^3/kg)(低压的一个值)
        [DllImport("IFC67", EntryPoint = "TH2VLP67")]
        public static extern void TH2VLP67(double T, double H, ref double V, ref int Range);
        //已知温度(℃)和比焓(kJ/kg)，求压力(MPa)(高压的一个值)
        [DllImport("IFC67", EntryPoint = "TH2PHP67")]
        public static extern void TH2PHP67(double T, double H, ref double P, ref int Range);
        //已知温度(℃)和比焓(kJ/kg)，求比熵(kJ/(kg.℃))(高压的一个值)
        [DllImport("IFC67", EntryPoint = "TH2SHP67")]
        public static extern void TH2SHP67(double T, double H, ref double S, ref int Range);
        //已知温度(℃)和比焓(kJ/kg)，求比容(m^3/kg)(高压的一个值)
        [DllImport("IFC67", EntryPoint = "TH2VHP67")]
        public static extern void TH2VHP67(double T, double H, ref double V, ref int Range);
        //已知温度(℃)和比焓(kJ/kg)，求压力(MPa)、比熵(kJ/(kg.℃))、比容(m^3/kg)、干度(100%)(低压的一个值)
        [DllImport("IFC67", EntryPoint = "THLP67")]
        public static extern void THLP67(ref double P, double T, double H, ref double S, ref double V, ref double X, ref int Range);
        //已知温度(℃)和比焓(kJ/kg)，求压力(MPa)、比熵(kJ/(kg.℃))、比容(m^3/kg)、干度(100%)(高压的一个值)
        [DllImport("IFC67", EntryPoint = "THHP67")]
        public static extern void THHP67(ref double P, double T, double H, ref double S, ref double V, ref double X, ref int Range);
        //已知温度(℃)和比焓(kJ/kg)，求压力(MPa)(缺省为低压的一个值)
        [DllImport("IFC67", EntryPoint = "TH2P67")]
        public static extern void TH2P67(double T, double H, ref double P, ref int Range);
        //已知温度(℃)和比焓(kJ/kg)，求比熵(kJ/(kg.℃))(缺省为低压的一个值)
        [DllImport("IFC67", EntryPoint = "TH2S67")]
        public static extern void TH2S67(double T, double H, ref double S, ref int Range);
        //已知温度(℃)和比焓(kJ/kg)，求比容(m^3/kg)(缺省为低压的一个值)
        [DllImport("IFC67", EntryPoint = "TH2V67")]
        public static extern void TH2V67(double T, double H, ref double V, ref int Range);
        //已知温度(℃)和比焓(kJ/kg)，求干度(100%)
        [DllImport("IFC67", EntryPoint = "TH2X67")]
        public static extern void TH2X67(double T, double H, ref double X, ref int Range);
        //已知温度(℃)和比焓(kJ/kg)，求压力(MPa)、比熵(kJ/(kg.℃))、比容(m^3/kg)、干度(100%)(缺省为低压的一个值)
        [DllImport("IFC67", EntryPoint = "TH67")]
        public static extern void TH67(ref double P, double T, double H, ref double S, ref double V, ref double X, ref int Range);

        //已知温度(℃)和比熵(kJ/(kg.℃))，求压力(MPa)(低压的一个值)
        [DllImport("IFC67", EntryPoint = "TS2PLP67")]
        public static extern void TS2PLP67(double T, double S, ref double P, ref int Range);
        //已知温度(℃)和比熵(kJ/(kg.℃))，求比焓(kJ/kg)(低压的一个值)
        [DllImport("IFC67", EntryPoint = "TS2HLP67")]
        public static extern void TS2HLP67(double T, double S, ref double H, ref int Range);
        //已知温度(℃)和比熵(kJ/(kg.℃))，求比容(m^3/kg)(低压的一个值)
        [DllImport("IFC67", EntryPoint = "TS2VLP67")]
        public static extern void TS2VLP67(double T, double S, ref double V, ref int Range);
        //已知温度(℃)和比熵(kJ/(kg.℃))，求压力(MPa)(高压的一个值)
        [DllImport("IFC67", EntryPoint = "TS2PHP67")]
        public static extern void TS2PHP67(double T, double S, ref double P, ref int Range);
        //已知温度(℃)和比熵(kJ/(kg.℃))，求比焓(kJ/kg)(高压的一个值)
        [DllImport("IFC67", EntryPoint = "TS2HLH67")]
        public static extern void TS2HHP67(double T, double S, ref double H, ref int Range);
        //已知温度(℃)和比熵(kJ/(kg.℃))，求比容(m^3/kg)(高压的一个值)
        [DllImport("IFC67", EntryPoint = "TS2VHP67")]
        public static extern void TS2VHP67(double T, double S, ref double V, ref int Range);
        //已知温度(℃)和比熵(kJ/(kg.℃))，求压力(MPa)(缺省为低压的一个值)
        [DllImport("IFC67", EntryPoint = "TS2P67")]
        public static extern void TS2P67(double T, double S, ref double P, ref int Range);
        //已知温度(℃)和比熵(kJ/(kg.℃))，求比焓(kJ/kg)(缺省为低压的一个值)
        [DllImport("IFC67", EntryPoint = "TS2H67")]
        public static extern void TS2H67(double T, double S, ref double H, ref int Range);
        //已知温度(℃)和比熵(kJ/(kg.℃))，求比容(m^3/kg)(缺省为低压的一个值)
        [DllImport("IFC67", EntryPoint = "TS2V67")]
        public static extern void TS2V67(double T, double S, ref double V, ref int Range);
        //已知温度(℃)和比熵(kJ/(kg.℃))，求干度(100%)
        [DllImport("IFC67", EntryPoint = "TS2X67")]
        public static extern void TS2X67(double T, double S, ref double X, ref int Range);
        //已知温度(℃)和比熵(kJ/(kg.℃))，求压力(MPa)、比焓(kJ/kg)、比容(m^3/kg)、干度(100%)(低压的一个值)
        [DllImport("IFC67", EntryPoint = "TSLP67")]
        public static extern void TSLP67(ref double P, double T, ref double H, double S, ref double V, ref double X, ref int Range);
        //已知温度(℃)和比熵(kJ/(kg.℃))，求压力(MPa)、比焓(kJ/kg)、比容(m^3/kg)、干度(100%)(高压的一个值)
        [DllImport("IFC67", EntryPoint = "TSHP67")]
        public static extern void TSHP67(ref double P, double T, ref double H, double S, ref double V, ref double X, ref int Range);
        //已知温度(℃)和比熵(kJ/(kg.℃))，求压力(MPa)、比焓(kJ/kg)、比容(m^3/kg)、干度(100%)(缺省为低压的一个值)
        [DllImport("IFC67", EntryPoint = "TS67")]
        public static extern void TS67(ref double P, double T, ref double H, double S, ref double V, ref double X, ref int Range);

        //已知温度(℃)和比容(m^3/kg)，求压力(MPa)
        [DllImport("IFC67", EntryPoint = "TV2P67")]
        public static extern void TV2P67(double T, double V, ref double P, ref int Range);
        //已知温度(℃)和比容(m^3/kg)，求比焓(kJ/kg)
        [DllImport("IFC67", EntryPoint = "TV2H67")]
        public static extern void TV2H67(double T, double V, ref double H, ref int Range);
        //已知温度(℃)和比容(m^3/kg)，求比熵(kJ/(kg.℃))
        [DllImport("IFC67", EntryPoint = "TV2S67")]
        public static extern void TV2S67(double T, double V, ref double S, ref int Range);
        //已知温度(℃)和比容(m^3/kg)，求干度(100%)
        [DllImport("IFC67", EntryPoint = "TV2X67")]
        public static extern void TV2X67(double T, double V, ref double X, ref int Range);
        //已知温度(℃)和比容(m^3/kg)，求压力(MPa)、比焓(kJ/kg)、比熵(kJ/(kg.℃))、干度(100%)
        [DllImport("IFC67", EntryPoint = "TV67")]
        public static extern void TV67(ref double P, double T, ref double H, ref double S, double V, ref double X, ref int Range);

        //已知温度(℃)和干度(100%)，求压力(MPa)
        [DllImport("IFC67", EntryPoint = "TX2P67")]
        public static extern void TX2P67(double T, double X, ref double P, ref int Range);
        //已知温度(℃)和干度(100%)，求比焓(kJ/kg)
        [DllImport("IFC67", EntryPoint = "TX2H67")]
        public static extern void TX2H67(double T, double X, ref double H, ref int Range);
        //已知温度(℃)和干度(100%)，求比熵(kJ/(kg.℃))
        [DllImport("IFC67", EntryPoint = "TX2S67")]
        public static extern void TX2S67(double T, double X, ref double S, ref int Range);
        //已知温度(℃)和干度(100%)，求比容(m^3/kg)
        [DllImport("IFC67", EntryPoint = "TX2V67")]
        public static extern void TX2V67(double T, double X, ref double V, ref int Range);
        //已知温度(℃)和干度(100%)，求压力(MPa)、比焓(kJ/kg)、比熵(kJ/(kg.℃))、比容(m^3/kg)
        [DllImport("IFC67", EntryPoint = "TX67")]
        public static extern void TX67(ref double P, double T, ref double H, ref double S, ref double V, double X, ref int Range);

        //已知比焓(kJ/kg)和比熵(kJ/(kg.℃))，求压力(MPa)
        [DllImport("IFC67", EntryPoint = "HS2P67")]
        public static extern void HS2P67(double H, double S, ref double P, ref int Range);
        //已知比焓(kJ/kg)和比熵(kJ/(kg.℃))，求温度(℃)
        [DllImport("IFC67", EntryPoint = "HS2T67")]
        public static extern void HS2T67(double H, double S, ref double T, ref int Range);
        //已知比焓(kJ/kg)和比熵(kJ/(kg.℃))，求比容(m^3/kg)
        [DllImport("IFC67", EntryPoint = "HS2V67")]
        public static extern void HS2V67(double H, double S, ref double V, ref int Range);
        //已知比焓(kJ/kg)和比熵(kJ/(kg.℃))，求干度(100%)
        [DllImport("IFC67", EntryPoint = "HS2X67")]
        public static extern void HS2X67(double H, double S, ref double X, ref int Range);
        //已知比焓(kJ/kg)和比熵(kJ/(kg.℃))，求压力(MPa)、温度(℃)、比容(m^3/kg)、干度(100%)
        [DllImport("IFC67", EntryPoint = "HS67")]
        public static extern void HS67(ref double P, ref double T, double H, double S, ref double V, ref double X, ref int Range);

        //已知比焓(kJ/kg)和比容(m^3/kg)，求压力(MPa)
        [DllImport("IFC67", EntryPoint = "HV2P67")]
        public static extern void HV2P67(double H, double V, ref double P, ref int Range);
        //已知比焓(kJ/kg)和比容(m^3/kg)，求温度(℃)
        [DllImport("IFC67", EntryPoint = "HV2T67")]
        public static extern void HV2T67(double H, double V, ref double T, ref int Range);
        //已知比焓(kJ/kg)和比容(m^3/kg)，求比熵(kJ/(kg.℃))
        [DllImport("IFC67", EntryPoint = "HV2S67")]
        public static extern void HV2S67(double H, double V, ref double S, ref int Range);
        //已知比焓(kJ/kg)和比容(m^3/kg)，求干度(100%)
        [DllImport("IFC67", EntryPoint = "HV2X67")]
        public static extern void HV2X67(double H, double V, ref double X, ref int Range);
        //已知比焓(kJ/kg)和比容(m^3/kg)，求压力(MPa)、温度(℃)、比熵(kJ/(kg.℃))、干度(100%)
        [DllImport("IFC67", EntryPoint = "HV67")]
        public static extern void HV67(ref double P, ref double T, double H, ref double S, double V, ref double X, ref int Range);

        //已知比焓(kJ/kg)和干度(100%)，求压力(MPa)(低压的一个值)
        [DllImport("IFC67", EntryPoint = "HX2PLP67")]
        public static extern void HX2PLP67(double H, double X, ref double P, ref int Range);
        //已知比焓(kJ/kg)和干度(100%)，求温度(℃)(低压的一个值)
        [DllImport("IFC67", EntryPoint = "HX2TLP67")]
        public static extern void HX2TLP67(double H, double X, ref double T, ref int Range);
        //已知比焓(kJ/kg)和干度(100%)，求比熵(kJ/(kg.℃))(低压的一个值)
        [DllImport("IFC67", EntryPoint = "HX2SLP67")]
        public static extern void HX2SLP67(double H, double X, ref double S, ref int Range);
        //已知比焓(kJ/kg)和干度(100%)，求比容(m^3/kg)(低压的一个值)
        [DllImport("IFC67", EntryPoint = "HX2VLP67")]
        public static extern void HX2VLP67(double H, double X, ref double V, ref int Range);
        //已知比焓(kJ/kg)和干度(100%)，求压力(MPa)(高压的一个值)
        [DllImport("IFC67", EntryPoint = "HX2PLP67")]
        public static extern void HX2PHP67(double H, double X, ref double P, ref int Range);
        //已知比焓(kJ/kg)和干度(100%)，求温度(℃)(高压的一个值)
        [DllImport("IFC67", EntryPoint = "HX2THP67")]
        public static extern void HX2THP67(double H, double X, ref double T, ref int Range);
        //已知比焓(kJ/kg)和干度(100%)，求比熵(kJ/(kg.℃))(高压的一个值)
        [DllImport("IFC67", EntryPoint = "HX2SHP67")]
        public static extern void HX2SHP67(double H, double X, ref double S, ref int Range);
        //已知比焓(kJ/kg)和干度(100%)，求比容(m^3/kg)(高压的一个值)
        [DllImport("IFC67", EntryPoint = "HX2VHP67")]
        public static extern void HX2VHP67(double H, double X, ref double V, ref int Range);
        //已知比焓(kJ/kg)和干度(100%)，求压力(MPa)(缺省是低压的一个值)
        [DllImport("IFC67", EntryPoint = "HX2P67")]
        public static extern void HX2P67(double H, double X, ref double P, ref int Range);
        //已知比焓(kJ/kg)和干度(100%)，求温度(℃)(缺省是低压的一个值)
        [DllImport("IFC67", EntryPoint = "HX2T67")]
        public static extern void HX2T67(double H, double X, ref double T, ref int Range);
        //已知比焓(kJ/kg)和干度(100%)，求比熵(kJ/(kg.℃))(缺省是低压的一个值)
        [DllImport("IFC67", EntryPoint = "HX2S7")]
        public static extern void HX2S7(double H, double X, ref double S, ref int Range);
        //已知比焓(kJ/kg)和干度(100%)，求比容(m^3/kg)(缺省是低压的一个值)
        [DllImport("IFC67", EntryPoint = "HX2V7")]
        public static extern void HX2V7(double H, double X, ref double V, ref int Range);
        //已知比焓(kJ/kg)和干度(100%)，求压力(MPa)、温度(℃)、比熵(kJ/(kg.℃))、比容(m^3/kg)(低压的一个值)
        [DllImport("IFC67", EntryPoint = "HXLP67")]
        public static extern void HXLP67(ref double P, ref double T, double H, ref double S, ref double V, double X, ref int Range);
        //已知比焓(kJ/kg)和干度(100%)，求压力(MPa)、温度(℃)、比熵(kJ/(kg.℃))、比容(m^3/kg)(高压的一个值)
        [DllImport("IFC67", EntryPoint = "HXHP67")]
        public static extern void HXHP67(ref double P, ref double T, double H, ref double S, ref double V, double X, ref int Range);
        //已知比焓(kJ/kg)和干度(100%)，求压力(MPa)、温度(℃)、比熵(kJ/(kg.℃))、比容(m^3/kg)(缺省是低压的一个值)
        [DllImport("IFC67", EntryPoint = "HX67")]
        public static extern void HX67(ref double P, ref double T, double H, ref double S, ref double V, double X, ref int Range);

        //已知比熵(kJ/(kg.℃))和比容(m^3/kg)，求压力(MPa)
        [DllImport("IFC67", EntryPoint = "SV2P67")]
        public static extern void SV2P67(double S, double V, ref double P, ref int Range);
        //已知比熵(kJ/(kg.℃))和比容(m^3/kg)，求温度(℃)
        [DllImport("IFC67", EntryPoint = "SV2T67")]
        public static extern void SV2T67(double S, double V, ref double T, ref int Range);
        //已知比熵(kJ/(kg.℃))和比容(m^3/kg)，求比焓(kJ/kg)
        [DllImport("IFC67", EntryPoint = "SV2H67")]
        public static extern void SV2H67(double S, double V, ref double H, ref int Range);
        //已知比熵(kJ/(kg.℃))和比容(m^3/kg)，求干度(100%)
        [DllImport("IFC67", EntryPoint = "SV2X67")]
        public static extern void SV2X67(double S, double V, ref double X, ref int Range);
        //已知比熵(kJ/(kg.℃))和比容(m^3/kg)，求压力(MPa)、温度(℃)、比焓(kJ/kg)、干度(100%)
        [DllImport("IFC67", EntryPoint = "SV67")]
        public static extern void SV67(ref double P, ref double T, ref double H, double S, double V, ref double X, ref int Range);

        //已知比熵(kJ/(kg.℃))和干度(100%)，求压力(MPa)(低压的一个值)
        [DllImport("IFC67", EntryPoint = "SX2PLP67")]
        public static extern void SX2PLP67(double S, double X, ref double P, ref int Range);
        //已知比熵(kJ/(kg.℃))和干度(100%)，求压力(MPa)(中压的一个值)
        [DllImport("IFC67", EntryPoint = "SX2PMP67")]
        public static extern void SX2PMP67(double S, double X, ref double P, ref int Range);
        //已知比熵(kJ/(kg.℃))和干度(100%)，求压力(MPa)(高压的一个值)
        [DllImport("IFC67", EntryPoint = "SX2PHP67")]
        public static extern void SX2PHP67(double S, double X, ref double P, ref int Range);
        //已知比熵(kJ/(kg.℃))和干度(100%)，求压力(MPa)(缺省是低压的一个值)
        [DllImport("IFC67", EntryPoint = "SX2P67")]
        public static extern void SX2P67(double S, double X, ref double P, ref int Range);
        //已知比熵(kJ/(kg.℃))和干度(100%)，求温度(℃)(低压的一个值)
        [DllImport("IFC67", EntryPoint = "SX2TLP67")]
        public static extern void SX2TLP67(double S, double X, ref double T, ref int Range);
        //已知比熵(kJ/(kg.℃))和干度(100%)，求温度(℃)(中压的一个值)
        [DllImport("IFC67", EntryPoint = "SX2TMP67")]
        public static extern void SX2TMP67(double S, double X, ref double T, ref int Range);
        //已知比熵(kJ/(kg.℃))和干度(100%)，求温度(℃)(高压的一个值)
        [DllImport("IFC67", EntryPoint = "SX2THP67")]
        public static extern void SX2THP67(double S, double X, ref double T, ref int Range);
        //已知比熵(kJ/(kg.℃))和干度(100%)，求温度(℃)(缺省是低压的一个值)
        [DllImport("IFC67", EntryPoint = "SX2T67")]
        public static extern void SX2T67(double S, double X, ref double T, ref int Range);
        //已知比熵(kJ/(kg.℃))和干度(100%)，求比焓(kJ/kg)(低压的一个值)
        [DllImport("IFC67", EntryPoint = "SX2HLP67")]
        public static extern void SX2HLP67(double S, double X, ref double H, ref int Range);
        //已知比熵(kJ/(kg.℃))和干度(100%)，求比焓(kJ/kg)(中压的一个值)
        [DllImport("IFC67", EntryPoint = "SX2HMP67")]
        public static extern void SX2HMP67(double S, double X, ref double H, ref int Range);
        //已知比熵(kJ/(kg.℃))和干度(100%)，求比焓(kJ/kg)(高压的一个值)
        [DllImport("IFC67", EntryPoint = "SX2HHP67")]
        public static extern void SX2HHP67(double S, double X, ref double H, ref int Range);
        //已知比熵(kJ/(kg.℃))和干度(100%)，求比焓(kJ/kg)(缺省是低压的一个值)
        [DllImport("IFC67", EntryPoint = "SX2H67")]
        public static extern void SX2H67(double S, double X, ref double H, ref int Range);
        //已知比熵(kJ/(kg.℃))和干度(100%)，求比容(m^3/kg)(低压的一个值)
        [DllImport("IFC67", EntryPoint = "SX2VLP67")]
        public static extern void SX2VLP67(double S, double X, ref double V, ref int Range);
        //已知比熵(kJ/(kg.℃))和干度(100%)，求比容(m^3/kg)(中压的一个值)
        [DllImport("IFC67", EntryPoint = "SX2VMP67")]
        public static extern void SX2VMP67(double S, double X, ref double V, ref int Range);
        //已知比熵(kJ/(kg.℃))和干度(100%)，求比容(m^3/kg)(高压的一个值)
        [DllImport("IFC67", EntryPoint = "SX2VHP67")]
        public static extern void SX2VHP67(double S, double X, ref double V, ref int Range);
        //已知比熵(kJ/(kg.℃))和干度(100%)，求比容(m^3/kg)(缺省是低压的一个值)
        [DllImport("IFC67", EntryPoint = "SX2V67")]
        public static extern void SX2V67(double S, double X, ref double V, ref int Range);
        //已知比熵(kJ/(kg.℃))和干度(100%)，求压力(MPa)、温度(℃)、比焓(kJ/kg)、比容(m^3/kg)(低压的一个值)
        [DllImport("IFC67", EntryPoint = "SXLP67")]
        public static extern void SXLP67(ref double P, ref double T, ref double H, double S, ref double V, double X, ref int Range);
        //已知比熵(kJ/(kg.℃))和干度(100%)，求压力(MPa)、温度(℃)、比焓(kJ/kg)、比容(m^3/kg)(中压的一个值)
        [DllImport("IFC67", EntryPoint = "SXMP67")]
        public static extern void SXMP67(ref double P, ref double T, ref double H, double S, ref double V, double X, ref int Range);
        //已知比熵(kJ/(kg.℃))和干度(100%)，求压力(MPa)、温度(℃)、比焓(kJ/kg)、比容(m^3/kg)(高压的一个值)
        [DllImport("IFC67", EntryPoint = "SXHP67")]
        public static extern void SXHP67(ref double P, ref double T, ref double H, double S, ref double V, double X, ref int Range);
        //已知比熵(kJ/(kg.℃))和干度(100%)，求压力(MPa)、温度(℃)、比焓(kJ/kg)、比容(m^3/kg)(缺省是低压的一个值)
        [DllImport("IFC67", EntryPoint = "SX67")]
        public static extern void SX67(ref double P, ref double T, ref double H, double S, ref double V, double X, ref int Range);

        //已知比容(m^3/kg)和干度(100%)，求压力(MPa)(低压的一个值)
        [DllImport("IFC67", EntryPoint = "VX2PLP67")]
        public static extern void VX2PLP67(double V, double X, ref double P, ref int Range);
        //已知比容(m^3/kg)和干度(100%)，求压力(MPa)(低高压的一个值)
        [DllImport("IFC67", EntryPoint = "VX2PHP67")]
        public static extern void VX2PHP67(double V, double X, ref double P, ref int Range);
        //已知比容(m^3/kg)和干度(100%)，求压力(MPa)(缺省是低压的一个值)
        [DllImport("IFC67", EntryPoint = "VX2P67")]
        public static extern void VX2P67(double V, double X, ref double P, ref int Range);
        //已知比容(m^3/kg)和干度(100%)，求温度(℃)(低压的一个值)
        [DllImport("IFC67", EntryPoint = "VX2TLP67")]
        public static extern void VX2TLP67(double V, double X, ref double T, ref int Range);
        //已知比容(m^3/kg)和干度(100%)，求温度(℃)(高压的一个值)
        [DllImport("IFC67", EntryPoint = "VX2THP67")]
        public static extern void VX2THP67(double V, double X, ref double T, ref int Range);
        //已知比容(m^3/kg)和干度(100%)，求温度(℃)(缺省是低压的一个值)
        [DllImport("IFC67", EntryPoint = "VX2T67")]
        public static extern void VX2T67(double V, double X, ref double T, ref int Range);
        //已知比容(m^3/kg)和干度(100%)，求比焓(kJ/kg)(低压的一个值)
        [DllImport("IFC67", EntryPoint = "VX2HLP67")]
        public static extern void VX2HLP67(double V, double X, ref double H, ref int Range);
        //已知比容(m^3/kg)和干度(100%)，求比焓(kJ/kg)(高压的一个值)
        [DllImport("IFC67", EntryPoint = "VX2HHP67")]
        public static extern void VX2HHP67(double V, double X, ref double H, ref int Range);
        //已知比容(m^3/kg)和干度(100%)，求比焓(kJ/kg)(缺省是低压的一个值)
        [DllImport("IFC67", EntryPoint = "VX2H67")]
        public static extern void VX2H67(double V, double X, ref double H, ref int Range);
        //已知比容(m^3/kg)和干度(100%)，求比熵(kJ/(kg.℃))(低压的一个值)
        [DllImport("IFC67", EntryPoint = "VX2SLP67")]
        public static extern void VX2SLP67(double V, double X, ref double S, ref int Range);
        //已知比容(m^3/kg)和干度(100%)，求比熵(kJ/(kg.℃))(高压的一个值)
        [DllImport("IFC67", EntryPoint = "VX2SHP67")]
        public static extern void VX2SHP67(double V, double X, ref double S, ref int Range);
        //已知比容(m^3/kg)和干度(100%)，求比熵(kJ/(kg.℃))(缺省是低压的一个值)
        [DllImport("IFC67", EntryPoint = "VX2S67")]
        public static extern void VX2S67(double V, double X, ref double S, ref int Range);
        //已知比容(m^3/kg)和干度(100%)，求压力(MPa)、温度(℃)、比焓(kJ/kg)、比熵(kJ/(kg.℃))(低压的一个值)
        [DllImport("IFC67", EntryPoint = "VXLP67")]
        public static extern void VXLP67(ref double P, ref double T, ref double H, ref double S, double V, double X, ref int Range);
        //已知比容(m^3/kg)和干度(100%)，求压力(MPa)、温度(℃)、比焓(kJ/kg)、比熵(kJ/(kg.℃))(高压的一个值)
        [DllImport("IFC67", EntryPoint = "VXHP67")]
        public static extern void VXHP67(ref double P, ref double T, ref double H, ref double S, double V, double X, ref int Range);
        //已知比容(m^3/kg)和干度(100%)，求压力(MPa)、温度(℃)、比焓(kJ/kg)、比熵(kJ/(kg.℃))(缺省是低压的一个值)
        [DllImport("IFC67", EntryPoint = "VX67")]
        public static extern void VX67(ref double P, ref double T, ref double H, ref double S, double V, double X, ref int Range);

        //******************************************************************************
        //标准流量测量装置计算
        //    已知
        //        PiFtype  --> 采用的标准、测量装置类型、取压方式
        //              (1) ISO 80-角接孔板         (2) ISO 80-法兰孔板
        //              (3) ISO 80-D和D/2孔板       (4) ISO 80-ISA1932喷嘴
        //              (5) ISO 80-长颈喷嘴         (6) ISO 91/98-角接孔板
        //              (7) ISO 91/98-法兰孔板      (8) ISO 91/98-D和D/2孔板
        //              (9) ISO 91/98-ISA1932喷嘴  (10) ISO 91/98-长颈喷嘴
        //             (11) GB 84 角结孔板         (12)  GB 84 法兰孔板
        //             (13) GB 84 ISA_1932喷嘴
        //        PiTclb   --> 校验时温度 (℃)
        //        PiLDclb  --> 校验时管道的内直径 (mm)
        //        PiSDclb  --> 校验时节流件的内直径 (mm)
        //        PiLagmaLD--> 管道的膨胀系数 (×10^(-6) mm/(mm.℃))
        //        PiLagmaSD--> 节流件的膨胀系数 (×10^(-6) mm/(mm.℃))
        //        PiKs     --> 管道绝对粗糙度 (mm)
        //        PiP1     --> 试验压力 (MPa)
        //        PiT1     --> 试验温度 (℃)
        //        PiDp     --> 试验差压 (MPa)
        //    求
        //        PiQm     --> 质量流量 (kg/h)。
        [DllImport("IFC67", EntryPoint = "SF2QM67")]
        public static extern void SF2QM67(ref int PiFtype, double PiTclb, double PiLDclb, double PiSDclb, double PiLagmaLD, double PiLagmaSD, double PiKs, double PiP1, double PiT1, double PiDp, ref double PiQm, ref int Range);

        //******************************************************************************
        //标准流量测量装置计算
        //    已知
        //        PiFtype  --> 采用的标准、测量装置类型、取压方式
        //              (1) ISO 80-角接孔板         (2) ISO 80-法兰孔板
        //              (3) ISO 80-D和D/2孔板       (4) ISO 80-ISA1932喷嘴
        //              (5) ISO 80-长颈喷嘴         (6) ISO 91/98-角接孔板
        //              (7) ISO 91/98-法兰孔板      (8) ISO 91/98-D和D/2孔板
        //              (9) ISO 91/98-ISA1932喷嘴  (10) ISO 91/98-长颈喷嘴
        //             (11) GB 84 角结孔板         (12)  GB 84 法兰孔板
        //             (13) GB 84 ISA_1932喷嘴
        //        PiTclb   --> 校验时温度 (℃)
        //        PiLDclb  --> 校验时管道的内直径 (mm)
        //        PiSDclb  --> 校验时节流件的内直径 (mm)
        //        PiLagmaLD--> 管道的膨胀系数 (×10^(-6) mm/(mm.℃))
        //        PiLagmaSD--> 节流件的膨胀系数 (×10^(-6) mm/(mm.℃))
        //        PiKs     --> 管道绝对粗糙度 (mm)
        //        PiP1     --> 试验压力 (MPa)
        //        PiT1     --> 试验温度 (℃)
        //        PiDp     --> 试验差压 (MPa)
        //    求
        //        PiC      --> 流出系数。
        [DllImport("IFC67", EntryPoint = "SF2C67")]
        public static extern void SF2C67(ref int PiFtype, double PiTclb, double PiLDclb, double PiSDclb, double PiLagmaLD, double PiLagmaSD, double PiKs, double PiP1, double PiT1, double PiDp, ref double PiC, ref int Range);

        //******************************************************************************
        //标准流量测量装置计算
        //    已知
        //        PiFtype  --> 采用的标准、测量装置类型、取压方式
        //              (1) ISO 80-角接孔板         (2) ISO 80-法兰孔板
        //              (3) ISO 80-D和D/2孔板       (4) ISO 80-ISA1932喷嘴
        //              (5) ISO 80-长颈喷嘴         (6) ISO 91/98-角接孔板
        //              (7) ISO 91/98-法兰孔板      (8) ISO 91/98-D和D/2孔板
        //              (9) ISO 91/98-ISA1932喷嘴  (10) ISO 91/98-长颈喷嘴
        //             (11) GB 84 角结孔板         (12)  GB 84 法兰孔板
        //             (13) GB 84 ISA_1932喷嘴
        //        PiTclb   --> 校验时温度 (℃)
        //        PiLDclb  --> 校验时管道的内直径 (mm)
        //        PiSDclb  --> 校验时节流件的内直径 (mm)
        //        PiLagmaLD--> 管道的膨胀系数 (×10^(-6) mm/(mm.℃))
        //        PiLagmaSD--> 节流件的膨胀系数 (×10^(-6) mm/(mm.℃))
        //        PiKs     --> 管道绝对粗糙度 (mm)
        //        PiP1     --> 试验压力 (MPa)
        //        PiT1     --> 试验温度 (℃)
        //        PiDp     --> 试验差压 (MPa)
        //    求
        //        PiALpha  --> 流量系数。
        [DllImport("IFC67", EntryPoint = "SF2A67")]
        public static extern void SF2A67(ref int PiFtype, double PiTclb, double PiLDclb, double PiSDclb, double PiLagmaLD, double PiLagmaSD, double PiKs, double PiP1, double PiT1, double PiDp, ref double PiALpha, ref int Range);
        //******************************************************************************
        //标准流量测量装置计算
        //    已知
        //        PiFtype  --> 采用的标准、测量装置类型、取压方式
        //              (1) ISO 80-角接孔板         (2) ISO 80-法兰孔板
        //              (3) ISO 80-D和D/2孔板       (4) ISO 80-ISA1932喷嘴
        //              (5) ISO 80-长颈喷嘴         (6) ISO 91/98-角接孔板
        //              (7) ISO 91/98-法兰孔板      (8) ISO 91/98-D和D/2孔板
        //              (9) ISO 91/98-ISA1932喷嘴  (10) ISO 91/98-长颈喷嘴
        //             (11) GB 84 角结孔板         (12)  GB 84 法兰孔板
        //             (13) GB 84 ISA_1932喷嘴
        //        PiTclb   --> 校验时温度 (℃)
        //        PiLDclb  --> 校验时管道的内直径 (mm)
        //        PiSDclb  --> 校验时节流件的内直径 (mm)
        //        PiLagmaLD--> 管道的膨胀系数 (×10^(-6) mm/(mm.℃))
        //        PiLagmaSD--> 节流件的膨胀系数 (×10^(-6) mm/(mm.℃))
        //        PiKs     --> 管道绝对粗糙度 (mm)
        //        PiP1     --> 试验压力 (MPa)
        //        PiT1     --> 试验温度 (℃)
        //        PiDp     --> 试验差压 (MPa)
        //    求
        //        PiReD    --> 管道雷诺数。
        [DllImport("IFC67", EntryPoint = "SF2RED67")]
        public static extern void SF2RED67(ref int PiFtype, double PiTclb, double PiLDclb, double PiSDclb, double PiLagmaLD, double PiLagmaSD, double PiKs, double PiP1, double PiT1, double PiDp, ref double PiRED, ref int Range);
        //******************************************************************************
        //校验流量测量装置计算
        //    已知
        //        PiFtype  --> 采用的标准、测量装置类型
        //                    (1) ASME 长径喷嘴
        //                    (2) ISO 长径喷嘴
        //                    (3) ISO/ ISA1932喷嘴
        //        PiTclb   --> 校验时温度 (℃)
        //        PiLDclb  --> 校验时管道的内直径 (mm)
        //        PiSDclb  --> 校验时节流件的内直径 (mm)
        //        PiLagmaLD--> 管道的膨胀系数 (×10^(-6) mm/(mm.℃))
        //        PiLagmaSD--> 节流件的膨胀系数 (×10^(-6) mm/(mm.℃))
        //        PiDCavg  --> 校验得到的各流出系数与标准流出系数曲线偏差量的平均值
        //        PiP1     --> 试验压力 (MPa)
        //        PiT1     --> 试验温度 (℃)
        //        PiDp     --> 试验差压 (MPa)
        //    求
        //        PiQm     --> 质量流量 (kg/h)。
        [DllImport("IFC67", EntryPoint = "CF2QM67")]
        public static extern void CF2QM67(ref int PiFtype, double PiTclb, double PiLDclb, double PiSDclb, double PiLagmaLD, double PiLagmaSD, double PiCxavg, double PiP1, double PiT1, double PiDp, ref double PiQm, ref int Range);
        //校验流量测量装置计算
        //    已知
        //        PiFtype  --> 采用的标准、测量装置类型
        //                    (1) ASME 长径喷嘴
        //                    (2) ISO 长径喷嘴
        //                    (3) ISO/ ISA1932喷嘴
        //        PiTclb   --> 校验时温度 (℃)
        //        PiLDclb  --> 校验时管道的内直径 (mm)
        //        PiSDclb  --> 校验时节流件的内直径 (mm)
        //        PiLagmaLD--> 管道的膨胀系数 (×10^(-6) mm/(mm.℃))
        //        PiLagmaSD--> 节流件的膨胀系数 (×10^(-6) mm/(mm.℃))
        //        PiDCavg  --> 校验得到的各流出系数与标准流出系数曲线偏差量的平均值
        //        PiP1     --> 试验压力 (MPa)
        //        PiT1     --> 试验温度 (℃)
        //        PiDp     --> 试验差压 (MPa)
        //    求
        //        PiC      --> 流出系数。
        [DllImport("IFC67", EntryPoint = "CF2C67")]
        public static extern void CF2C67(ref int PiFtype, double PiTclb, double PiLDclb, double PiSDclb, double PiLagmaLD, double PiLagmaSD, double PiCxavg, double PiP1, double PiT1, double PiDp, ref double PiC, ref int Range);
        //校验流量测量装置计算
        //    已知
        //        PiFtype  --> 采用的标准、测量装置类型
        //                    (1) ASME 长径喷嘴
        //                    (2) ISO 长径喷嘴
        //                    (3) ISO/ ISA1932喷嘴
        //        PiTclb   --> 校验时温度 (℃)
        //        PiLDclb  --> 校验时管道的内直径 (mm)
        //        PiSDclb  --> 校验时节流件的内直径 (mm)
        //        PiLagmaLD--> 管道的膨胀系数 (×10^(-6) mm/(mm.℃))
        //        PiLagmaSD--> 节流件的膨胀系数 (×10^(-6) mm/(mm.℃))
        //        PiDCavg  --> 校验得到的各流出系数与标准流出系数曲线偏差量的平均值
        //        PiP1     --> 试验压力 (MPa)
        //        PiT1     --> 试验温度 (℃)
        //        PiDp     --> 试验差压 (MPa)
        //    求
        //        PiALpha  --> 流量系数。
        [DllImport("IFC67", EntryPoint = "CF2A67")]
        public static extern void CF2A67(ref int PiFtype, double PiTclb, double PiLDclb, double PiSDclb, double PiLagmaLD, double PiLagmaSD, double PiCxavg, double PiP1, double PiT1, double PiDp, ref double PiALpha, ref int Range);

        //校验流量测量装置计算
        //    已知
        //        PiFtype  --> 采用的标准、测量装置类型
        //                    (1) ASME 长径喷嘴
        //                    (2) ISO 长径喷嘴
        //                    (3) ISO/ ISA1932喷嘴
        //        PiTclb   --> 校验时温度 (℃)
        //        PiLDclb  --> 校验时管道的内直径 (mm)
        //        PiSDclb  --> 校验时节流件的内直径 (mm)
        //        PiLagmaLD--> 管道的膨胀系数 (×10^(-6) mm/(mm.℃))
        //        PiLagmaSD--> 节流件的膨胀系数 (×10^(-6) mm/(mm.℃))
        //        PiDCavg  --> 校验得到的各流出系数与标准流出系数曲线偏差量的平均值
        //        PiP1     --> 试验压力 (MPa)
        //        PiT1     --> 试验温度 (℃)
        //        PiDp     --> 试验差压 (MPa)
        //    求
        //        PiReD    --> 管道雷诺数。
        [DllImport("IFC67", EntryPoint = "CF2RED67")]
        public static extern void CF2RED67(ref int PiFtype, double PiTclb, double PiLDclb, double PiSDclb, double PiLagmaLD, double PiLagmaSD, double PiCxavg, double PiP1, double PiT1, double PiDp, ref double PiReD, ref int Range);

        //******************************************************************************
        //计算除氧器给水箱水位变化的等效流量
        //    已知
        //        L    --> 给水箱的全长度 (米)；
        //        ML   --> 中部圆筒体的长度 (米)；
        //        R    --> 中部圆筒体的内半径 (米)；
        //        HS   --> 起始水位(以圆筒体中心线为水位高度的零位) (米)；
        //        HE   --> 结束水位(以圆筒体中心线为水位高度的零位) (米)；
        //        DT   --> 持续时间 (分钟)
        //        V    --> 平均比容 (m^3/kg)
        //    求
        //        PiQm --> 质量流量 (kg/h)。
        [DllImport("IFC67", EntryPoint = "DEATANKEQUFLOW67")]
        public static extern void DEATANKEQUFLOW67(double L, double ML, double R, double HS, double HE, double DT, double v, ref double GFlow, ref int Range);

        //计算四方柱体热井水位变化的等效流量
        //    已知
        //        L    --> 热井的长度 (米)；
        //        WT   --> 热井的顶部宽度 (米)；
        //        WB   --> 热井的底部宽度 (米)；
        //        H    --> 热井的高度 (米)；
        //        HS   --> 试验开始水位 (米)；
        //        HE   --> 试验结束水位 (米)；
        //        DT   --> 持续时间 (分钟);
        //        V    --> 热井水的平均比容 (m^3/kg);
        //    求
        //        PiQm --> 质量流量 (kg/h)。
        [DllImport("IFC67", EntryPoint = "HWBOXEQUFLOW67")]
        public static extern void HWBOXEQUFLOW67(double L, double WT, double WB, double H, double HS, double HE, double DT, double v, ref double GFlow, ref int Range);
        //计算圆柱体热井水位变化的等效流量
        //    已知
        //        R    --> 圆柱体的半径 (米)；
        //        HS   --> 起始水位 (米);
        //        HE   --> 结束水位 (米);
        //        DT   --> 持续时间 (分钟);
        //        V    --> 热井水的平均比容 (m^3/kg);
        //    求
        //        PiQm --> 质量流量 (kg/h)。
        [DllImport("IFC67", EntryPoint = "HWCLDEQUFLOW67")]
        public static extern void HWCLDEQUFLOW67(double R, double HS, double HE, double DT, double v, ref double GFlow, ref int Range);

        //******************************************************************************
        //热耗/出力的修正计算
        //采用分段线性插值法
        //UNO-->机组物理编号
        [DllImport("IFC67", EntryPoint = "HR_Nel_Crt67")]
        public static extern void HR_Nel_Crt67(int UNO, int PItem, double PIn, ref double POut, ref int Range);
        //计算主汽压力对热耗的修正系数
        [DllImport("IFC67", EntryPoint = "PTHR2HR67")]
        public static extern void PTHR2HR67(int UNO, double PIn, ref double POut, ref int Range);
        //计算主汽温度对热耗的修正系数
        [DllImport("IFC67", EntryPoint = "TTHR2HR67")]
        public static extern void TTHR2HR67(int UNO, double PIn, ref double POut, ref int Range);
        //计算再热压损对热耗的修正系数
        [DllImport("IFC67", EntryPoint = "DPRH2HR67")]
        public static extern void DPRH2HR67(int UNO, double PIn, ref double POut, ref int Range);
        //计算再热温度对热耗的修正系数
        [DllImport("IFC67", EntryPoint = "TRH2HR67")]
        public static extern void TRH2HR67(int UNO, double PIn, ref double POut, ref int Range);
        //计算排汽压力对热耗的修正系数
        [DllImport("IFC67", EntryPoint = "PEXH2HR67")]
        public static extern void PEXH2HR67(int UNO, double PIn, ref double POut, ref int Range);
        //计算主汽压力对出力的修正系数
        [DllImport("IFC67", EntryPoint = "PTHR2NEL67")]
        public static extern void PTHR2NEL67(int UNO, double PIn, ref double POut, ref int Range);
        //计算主汽温度对出力的修正系数
        [DllImport("IFC67", EntryPoint = "TTHR2NEL67")]
        public static extern void TTHR2NEL67(int UNO, double PIn, ref double POut, ref int Range);
        //计算再热压损对出力的修正系数
        [DllImport("IFC67", EntryPoint = "DPRH2NEL67")]
        public static extern void DPRH2NEL67(int UNO, double PIn, ref double POut, ref int Range);
        //计算再热温度对出力的修正系数
        [DllImport("IFC67", EntryPoint = "TRH2NEL67")]
        public static extern void TRH2NEL67(int UNO, double PIn, ref double POut, ref int Range);
        //计算排汽压力对出力的修正系数
        [DllImport("IFC67", EntryPoint = "PEXH2NEL67")]
        public static extern void PEXH2NEL67(int UNO, double PIn, ref double POut, ref int Range);
        //计算发电机的机电损失
        [DllImport("IFC67", EntryPoint = "NI2DNMG67")]
        public static extern void NI2DNMG67(int UNO, double PIn, ref double POut, ref int Range);
        //排汽环面速度的损失
        [DllImport("IFC67", EntryPoint = "VC2DHEXH67")]
        public static extern void VC2DHEXH67(int UNO, double PIn, ref double POut, ref int Range);


        //******************************************************************************
        //已知两个点的X、Y值，线性插值(先输入两个点的X值，再输入两个点的Y值)
        [DllImport("IFC67", EntryPoint = "INST2DXX67")]
        public static extern void INST2DXX67(double X1, double X2, double Y1, double Y2, double X, ref double Y);
        //已知两个点的X、Y值，线性插值(先输入一个点的X值和Y值，再输入另外一个点的X值和Y值)
        [DllImport("IFC67", EntryPoint = "INST2DXY67")]
        public static extern void INST2DXY67(double X1, double Y1, double X2, double Y2, double X, ref double Y);
    }
}
