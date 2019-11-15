using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CommonLib
{

    /*
       根据IAPWS-IF97编写的动态链接库的函数的调用接口声明
        专供Borland C# Builder (C#语言) 使用

        使用方法：

        直接把本软件包提供的类文件(SWIF97.cs)加进对应项目，
        在需要调用函数的单元中引用本类文件的命名空间(using SWIF97IFC67)即可！

        把类文件(SWIF97.cs)包括进入项目的菜单路径为：
            [Project]|[Add to Project... Shift+F11]

        在需要调用函数的单元中引用本类文件的命名空间(using SWIF97IFC67)时无菜单路径，需手工输入！
    */
    public class SWIF97
    {
        //动态连接库中函数的声明
        //C#中的声明

        //已知压力(MPa)，求对应饱和温度(℃)
        [DllImport("IF97", EntryPoint = "P2T97")]
        public static extern void P2T97(double P, ref double T, ref int Range);
        //已知压力(MPa)，求对应饱和水比焓(kJ/kg)
        [DllImport("IF97", EntryPoint = "P2HL97")]
        public static extern void P2HL97(double P, ref double H, ref int Range);
        //已知压力(MPa)，求对应饱和汽比焓(kJ/kg)
        [DllImport("IF97", EntryPoint = "P2HG97")]
        public static extern void P2HG97(double P, ref double H, ref int Range);
        //已知压力(MPa)，求对应饱和水比熵(kJ/(kg.℃))
        [DllImport("IF97", EntryPoint = "P2SL97")]
        public static extern void P2SL97(double P, ref double S, ref int Range);
        //已知压力(MPa)，求对应饱和汽比熵(kJ/(kg.℃))
        [DllImport("IF97", EntryPoint = "P2SG97")]
        public static extern void P2SG97(double P, ref double S, ref int Range);
        //已知压力(MPa)，求对应饱和水比容(m^3/kg)
        [DllImport("IF97", EntryPoint = "P2VL97")]
        public static extern void P2VL97(double P, ref double V, ref int Range);
        //已知压力(MPa)，求对应饱和汽比容(m^3/kg)
        [DllImport("IF97", EntryPoint = "P2VL97")]
        public static extern void P2VG97(double P, ref double V, ref int Range);
        //已知压力(MPa)，求对应饱和温度(℃)、饱和水比焓(kJ/kg)、饱和水比熵(kJ/(kg.℃))、饱和水比容(m^3/kg)
        [DllImport("IF97", EntryPoint = "P2L97")]
        public static extern void P2L97(double P, ref double T, ref double H, ref double S, ref double V, ref double X, ref int Range);
        //已知压力(MPa)，求对应饱和温度(℃)、饱和汽比焓(kJ/kg)、饱和汽比熵(kJ/(kg.℃))、饱和汽比容(m^3/kg)
        [DllImport("IF97", EntryPoint = "P2G97")]
        public static extern void P2G97(double P, ref double T, ref double H, ref double S, ref double V, ref double X, ref int Range);
        //已知压力(MPa)，求对应饱和水定压比热(kJ/(kg.℃))
        [DllImport("IF97", EntryPoint = "P2CPL97")]
        public static extern void P2CPL97(double P, ref double CP, ref int Range);
        //已知压力(MPa)，求对应饱和汽定压比热(kJ/(kg.℃))
        [DllImport("IF97", EntryPoint = "P2CPG97")]
        public static extern void P2CPG97(double P, ref double CP, ref int Range);
        //已知压力(MPa)，求对应饱和水定容比热(kJ/(kg.℃))
        [DllImport("IF97", EntryPoint = "P2CVL97")]
        public static extern void P2CVL97(double P, ref double CV, ref int Range);
        //已知压力(MPa)，求对应饱和汽定容比热(kJ/(kg.℃))
        [DllImport("IF97", EntryPoint = "P2CVG97")]
        public static extern void P2CVG97(double P, ref double CV, ref int Range);
        //已知压力(MPa)，求对应饱和水内能(kJ/kg)
        [DllImport("IF97", EntryPoint = "P2EL97")]
        public static extern void P2EL97(double P, ref double E, ref int Range);
        //已知压力(MPa)，求对应饱和汽内能(kJ/kg)
        [DllImport("IF97", EntryPoint = "P2EG97")]
        public static extern void P2EG97(double P, ref double E, ref int Range);
        //已知压力(MPa)，求对应饱和水音速(m/s)
        [DllImport("IF97", EntryPoint = "P2SSPL97")]
        public static extern void P2SSPL97(double P, ref double SSP, ref int Range);
        //已知压力(MPa)，求对应饱和汽音速(m/s)
        [DllImport("IF97", EntryPoint = "P2SSPG97")]
        public static extern void P2SSPG97(double P, ref double SSP, ref int Range);
        //已知压力(MPa)，求对应饱和水定熵指数
        [DllImport("IF97", EntryPoint = "P2KSL97")]
        public static extern void P2KSL97(double P, ref double KS, ref int Range);
        //已知压力(MPa)，求对应饱和汽定熵指数
        [DllImport("IF97", EntryPoint = "P2KSG97")]
        public static extern void P2KSG97(double P, ref double KS, ref int Range);
        //已知压力(MPa)，求对应饱和水动力粘度(Pa.s)
        [DllImport("IF97", EntryPoint = "P2ETAL97")]
        public static extern void P2ETAL97(double P, ref double ETA, ref int Range);
        //已知压力(MPa)，求对应饱和汽动力粘度(Pa.s)
        [DllImport("IF97", EntryPoint = "P2ETAG97")]
        public static extern void P2ETAG97(double P, ref double ETA, ref int Range);
        //已知压力(MPa)，求对应饱和水运动粘度(m^2/s)
        [DllImport("IF97", EntryPoint = "P2UL97")]
        public static extern void P2UL97(double P, ref double U, ref int Range);
        //已知压力(MPa)，求对应饱和汽运动粘度(m^2/s)
        [DllImport("IF97", EntryPoint = "P2UG97")]
        public static extern void P2UG97(double P, ref double U, ref int Range);
        //已知压力(MPa)，求对应饱和水导热系数(W/(m.℃))
        [DllImport("IF97", EntryPoint = "P2RAMDL97")]
        public static extern void P2RAMDL97(double P, ref double RAMD, ref int Range);
        //已知压力(MPa)，求对应饱和汽导热系数(W/(m.℃))
        [DllImport("IF97", EntryPoint = "P2RAMDG97")]
        public static extern void P2RAMDG97(double P, ref double RAMD, ref int Range);
        //已知压力(MPa)，求对应饱和水普朗特数
        [DllImport("IF97", EntryPoint = "P2PRNL97")]
        public static extern void P2PRNL97(double P, ref double PRN, ref int Range);
        //已知压力(MPa)，求对应饱和汽普朗特数
        [DllImport("IF97", EntryPoint = "P2PRNG97")]
        public static extern void P2PRNG97(double P, ref double PRN, ref int Range);
        //已知压力(MPa)，求对应饱和水介电常数
        [DllImport("IF97", EntryPoint = "P2EPSL97")]
        public static extern void P2EPSL97(double P, ref double EPS, ref int Range);
        //已知压力(MPa)，求对应饱和汽介电常数
        [DllImport("IF97", EntryPoint = "P2EPSG97")]
        public static extern void P2EPSG97(double P, ref double EPS, ref int Range);
        //已知压力(MPa)，求对应饱和水折射率
        [DllImport("IF97", EntryPoint = "P2NL97")]
        public static extern void P2NL97(double P, double LAMD, ref double N, ref int Range);
        //已知压力(MPa)，求对应饱和汽折射率
        [DllImport("IF97", EntryPoint = "P2NG97")]
        public static extern void P2NG97(double P, double LAMD, ref double N, ref int Range);

        //已知压力(MPa)和温度(℃)，求比焓(kJ/kg)
        [DllImport("IF97", EntryPoint = "PT2H97")]
        public static extern void PT2H97(double P, double T, ref double H, ref int Range);
        //已知压力(MPa)和温度(℃)，求比熵(kJ/(kg.℃))
        [DllImport("IF97", EntryPoint = "PT2S97")]
        public static extern void PT2S97(double P, double T, ref double S, ref int Range);
        //已知压力(MPa)和温度(℃)，求比容(m^3/kg)
        [DllImport("IF97", EntryPoint = "PT2V97")]
        public static extern void PT2V97(double P, double T, ref double V, ref int Range);
        //已知压力(MPa)和温度(℃)，求干度(100%)
        [DllImport("IF97", EntryPoint = "PT2X97")]
        public static extern void PT2X97(double P, double T, ref double X, ref int Range);
        //已知压力(MPa)和温度(℃)，求比焓(kJ/kg)、比熵(kJ/(kg.℃))、比容(m^3/kg)
        [DllImport("IF97", EntryPoint = "PT97")]
        public static extern void PT97(double P, double T, ref double H, ref double S, ref double V, ref double X, ref int Range);
        //已知压力(MPa)和温度(℃)，求定压比热(kJ/(kg.℃))
        [DllImport("IF97", EntryPoint = "PT2CP97")]
        public static extern void PT2CP97(double P, double T, ref double CP, ref int Range);
        //已知压力(MPa)和温度(℃)，求定容比热(kJ/(kg.℃))
        [DllImport("IF97", EntryPoint = "PT2CV97")]
        public static extern void PT2CV97(double P, double T, ref double CV, ref int Range);
        //已知压力(MPa)和温度(℃)，求内能(kJ/kg)
        [DllImport("IF97", EntryPoint = "PT2E97")]
        public static extern void PT2E97(double P, double T, ref double E, ref int Range);
        //已知压力(MPa)和温度(℃)，求音速(m/s)
        [DllImport("IF97", EntryPoint = "PT2SSP97")]
        public static extern void PT2SSP97(double P, double T, ref double SSP, ref int Range);
        //已知压力(MPa)和温度(℃)，求定熵指数
        [DllImport("IF97", EntryPoint = "PT2KS97")]
        public static extern void PT2KS97(double P, double T, ref double KS, ref int Range);
        //已知压力(MPa)和温度(℃)，求动力粘度(Pa.s)
        [DllImport("IF97", EntryPoint = "PT2ETA97")]
        public static extern void PT2ETA97(double P, double T, ref double ETA, ref int Range);
        //已知压力(MPa)和温度(℃)，求运动粘度(m^2/s)
        [DllImport("IF97", EntryPoint = "PT2U97")]
        public static extern void PT2U97(double P, double T, ref double U, ref int Range);
        //已知压力(MPa)和温度(℃)，求热传导系数 (W/(m.℃))
        [DllImport("IF97", EntryPoint = "PT2RAMD97")]
        public static extern void PT2RAMD97(double P, double T, ref double RAMD, ref int Range);
        //已知压力(MPa)和温度(℃)，求普朗特数
        [DllImport("IF97", EntryPoint = "PT2PRN97")]
        public static extern void PT2PRN97(double P, double T, ref double PRN, ref int Range);
        //已知压力(MPa)和温度(℃)，求介电常数
        [DllImport("IF97", EntryPoint = "PT2EPS97")]
        public static extern void PT2EPS97(double P, double T, ref double EPS, ref int Range);
        //已知压力(MPa)和温度(℃)，求折射率
        [DllImport("IF97", EntryPoint = "PT2N97")]
        public static extern void PT2N97(double P, double T, double LAMD, ref double N, ref int Range);

        //已知压力(MPa)和比焓(kJ/kg)，求温度(℃)
        [DllImport("IF97", EntryPoint = "PH2T97")]
        public static extern void PH2T97(double P, double H, ref double T, ref int Range);
        //已知压力(MPa)和比焓(kJ/kg)，求比熵(kJ/(kg.℃))
        [DllImport("IF97", EntryPoint = "PH2S97")]
        public static extern void PH2S97(double P, double H, ref double S, ref int Range);
        //已知压力(MPa)和比焓(kJ/kg)，求比容(m^3/kg)
        [DllImport("IF97", EntryPoint = "PH2V97")]
        public static extern void PH2V97(double P, double H, ref double V, ref int Range);
        //已知压力(MPa)和比焓(kJ/kg)，求干度(100%)
        [DllImport("IF97", EntryPoint = "PH2X97")]
        public static extern void PH2X97(double P, double H, ref double X, ref int Range);
        //已知压力(MPa)和比焓(kJ/kg)，求温度(℃)、比熵(kJ/(kg.℃))、比容(m^3/kg)、干度(100%)
        [DllImport("IF97", EntryPoint = "PH97")]
        public static extern void PH97(double P, ref double T, double H, ref double S, ref double V, ref double X, ref int Range);

        //已知压力(MPa)和比熵(kJ/(kg.℃))，求温度(℃)
        [DllImport("IF97", EntryPoint = "PS2T97")]
        public static extern void PS2T97(double P, double S, ref double T, ref int Range);
        //已知压力(MPa)和比熵(kJ/(kg.℃))，求比焓(kJ/kg)
        [DllImport("IF97", EntryPoint = "PS2H97")]
        public static extern void PS2H97(double P, double S, ref double H, ref int Range);
        //已知压力(MPa)和比熵(kJ/(kg.℃))，求比容(m^3/kg)
        [DllImport("IF97", EntryPoint = "PS2V97")]
        public static extern void PS2V97(double P, double S, ref double V, ref int Range);
        //已知压力(MPa)和比熵(kJ/(kg.℃))，求干度(100%)
        [DllImport("IF97", EntryPoint = "PS2TX7")]
        public static extern void PS2X97(double P, double S, ref double X, ref int Range);
        //已知压力(MPa)和比熵(kJ/(kg.℃))，求温度(℃)、比焓(kJ/kg)、比容(m^3/kg)、干度(100%)
        [DllImport("IF97", EntryPoint = "PS97")]
        public static extern void PS97(double P, ref double T, ref double H, double S, ref double V, ref double X, ref int Range);

        //已知压力(MPa)和比容(m^3/kg)，求温度(℃)
        [DllImport("IF97", EntryPoint = "PV2T97")]
        public static extern void PV2T97(double P, double V, ref double T, ref int Range);
        //已知压力(MPa)和比容(m^3/kg)，求比焓(kJ/kg)
        [DllImport("IF97", EntryPoint = "PV2H97")]
        public static extern void PV2H97(double P, double V, ref double H, ref int Range);
        //已知压力(MPa)和比容(m^3/kg)，求比容(m^3/kg)
        [DllImport("IF97", EntryPoint = "PV2S97")]
        public static extern void PV2S97(double P, double V, ref double S, ref int Range);
        //已知压力(MPa)和比容(m^3/kg)，求干度(100%)
        [DllImport("IF97", EntryPoint = "PV2X97")]
        public static extern void PV2X97(double P, double V, ref double X, ref int Range);
        //已知压力(MPa)和比容(m^3/kg)，求温度(℃)、比焓(kJ/kg)、比容(m^3/kg)、干度(100%)
        [DllImport("IF97", EntryPoint = "PV97")]
        public static extern void PV97(double P, ref double T, ref double H, ref double S, double V, ref double X, ref int Range);

        //已知压力(MPa)和干度(100%)，求温度(℃)
        [DllImport("IF97", EntryPoint = "PX2T97")]
        public static extern void PX2T97(double P, double X, ref double T, ref int Range);
        //已知压力(MPa)和干度(100%)，求比焓(kJ/kg)
        [DllImport("IF97", EntryPoint = "PX2H97")]
        public static extern void PX2H97(double P, double X, ref double H, ref int Range);
        //已知压力(MPa)和干度(100%)，求比熵(kJ/(kg.℃))
        [DllImport("IF97", EntryPoint = "PX2S97")]
        public static extern void PX2S97(double P, double X, ref double S, ref int Range);
        //已知压力(MPa)和干度(100%)，求比容(m^3/kg)
        [DllImport("IF97", EntryPoint = "PX2V97")]
        public static extern void PX2V97(double P, double X, ref double V, ref int Range);
        //已知压力(MPa)和干度(100%)，求温度(℃)、比焓(kJ/kg)、比熵(kJ/(kg.℃))、比容(m^3/kg)
        [DllImport("IF97", EntryPoint = "PX97")]
        public static extern void PX97(double P, ref double T, ref double H, ref double S, ref double V, double X, ref int Range);

        //已知温度(℃)，求饱和压力(MPa)？
        [DllImport("IF97", EntryPoint = "T2P97")]
        public static extern void T2P97(double T, ref double P, ref int Range);
        //已知温度(℃)，求饱和水比焓(kJ/kg)
        [DllImport("IF97", EntryPoint = "T2HL97")]
        public static extern void T2HL97(double T, ref double H, ref int Range);
        //已知温度(℃)，求饱和汽比焓(kJ/kg)
        [DllImport("IF97", EntryPoint = "T2HG97")]
        public static extern void T2HG97(double T, ref double H, ref int Range);
        //已知温度(℃)，求饱和水比熵(kJ/(kg.℃))
        [DllImport("IF97", EntryPoint = "T2SL97")]
        public static extern void T2SL97(double T, ref double S, ref int Range);
        //已知温度(℃)，求饱和汽比熵(kJ/(kg.℃))
        [DllImport("IF97", EntryPoint = "T2SG97")]
        public static extern void T2SG97(double T, ref double S, ref int Range);
        //已知温度(℃)，求饱和水比容(m^3/kg)
        [DllImport("IF97", EntryPoint = "T2VL97")]
        public static extern void T2VL97(double T, ref double V, ref int Range);
        //已知温度(℃)，求饱和汽比容(m^3/kg)
        [DllImport("IF97", EntryPoint = "T2VG97")]
        public static extern void T2VG97(double T, ref double V, ref int Range);
        //已知温度(℃)，求饱和水比焓(kJ/kg)、饱和水比熵(kJ/(kg.℃))、饱和水比容(m^3/kg)
        [DllImport("IF97", EntryPoint = "T2L97")]
        public static extern void T2L97(ref double P, double T, ref double V, ref int Range);
        //已知温度(℃)，求饱和汽比焓(kJ/kg)、饱和汽比熵(kJ/(kg.℃))、饱和汽比容(m^3/kg)
        [DllImport("IF97", EntryPoint = "T2G97")]
        public static extern void T2G97(ref double P, double T, ref double V, ref int Range);
        //已知温度(℃)，求饱和水定压比热(kJ/(kg.℃))
        [DllImport("IF97", EntryPoint = "T2CPL97")]
        public static extern void T2CPL97(double T, ref double CP, ref int Range);
        //已知温度(℃)，求饱和汽定压比热(kJ/(kg.℃))
        [DllImport("IF97", EntryPoint = "T2CPL97")]
        public static extern void T2CPG97(double T, ref double CP, ref int Range);
        //已知温度(℃)，求饱和水定容比热(kJ/(kg.℃))
        [DllImport("IF97", EntryPoint = "T2CVL97")]
        public static extern void T2CVL97(double T, ref double CV, ref int Range);
        //已知温度(℃)，求饱和汽定容比热(kJ/(kg.℃))
        [DllImport("IF97", EntryPoint = "T2CVG97")]
        public static extern void T2CVG97(double T, ref double CV, ref int Range);
        //已知温度(℃)，求饱和水内能(kJ/kg)
        [DllImport("IF97", EntryPoint = "T2EL97")]
        public static extern void T2EL97(double T, ref double E, ref int Range);
        //已知温度(℃)，求饱和汽内能(kJ/kg)
        [DllImport("IF97", EntryPoint = "T2EG97")]
        public static extern void T2EG97(double T, ref double E, ref int Range);
        //已知温度(℃)，求饱和水音速(m/s)
        [DllImport("IF97", EntryPoint = "T2SSPL97")]
        public static extern void T2SSPL97(double T, ref double SSP, ref int Range);
        //已知温度(℃)，求饱和汽音速(m/s)
        [DllImport("IF97", EntryPoint = "T2SSPG97")]
        public static extern void T2SSPG97(double T, ref double SSP, ref int Range);
        //已知温度(℃)，求饱和水定熵指数
        [DllImport("IF97", EntryPoint = "T2KSL97")]
        public static extern void T2KSL97(double T, ref double KS, ref int Range);
        //已知温度(℃)，求饱和汽定熵指数
        [DllImport("IF97", EntryPoint = "T2KSG97")]
        public static extern void T2KSG97(double T, ref double KS, ref int Range);
        //已知温度(℃)，求饱和水动力粘度(Pa.s)
        [DllImport("IF97", EntryPoint = "T2ETAL97")]
        public static extern void T2ETAL97(double T, ref double ETA, ref int Range);
        //已知温度(℃)，求饱和汽动力粘度(Pa.s)
        [DllImport("IF97", EntryPoint = "T2ETAG97")]
        public static extern void T2ETAG97(double T, ref double ETA, ref int Range);
        //已知温度(℃)，求饱和水运动粘度(m^2/s)
        [DllImport("IF97", EntryPoint = "T2UL97")]
        public static extern void T2UL97(double T, ref double U, ref int Range);
        //已知温度(℃)，求饱和汽运动粘度(m^2/s)
        [DllImport("IF97", EntryPoint = "T2UG97")]
        public static extern void T2UG97(double T, ref double U, ref int Range);
        //已知温度(℃)，求饱和水导热系数(W/(m.℃))
        [DllImport("IF97", EntryPoint = "T2RAMDL97")]
        public static extern void T2RAMDL97(double T, ref double RAMD, ref int Range);
        //已知温度(℃)，求饱和汽导热系数(W/(m.℃))
        [DllImport("IF97", EntryPoint = "T2RAMDG97")]
        public static extern void T2RAMDG97(double T, ref double RAMD, ref int Range);
        //已知温度(℃)，求饱和水普朗特数
        [DllImport("IF97", EntryPoint = "T2PRNL97")]
        public static extern void T2PRNL97(double T, ref double PRN, ref int Range);
        //已知温度(℃)，求饱和汽普朗特数
        [DllImport("IF97", EntryPoint = "T2PRNG97")]
        public static extern void T2PRNG97(double T, ref double PRN, ref int Range);
        //已知温度(℃)，求饱和水介电常数
        [DllImport("IF97", EntryPoint = "T2EPSL97")]
        public static extern void T2EPSL97(double T, ref double EPS, ref int Range);
        //已知温度(℃)，求饱和汽介电常数
        [DllImport("IF97", EntryPoint = "T2EPSG97")]
        public static extern void T2EPSG97(double T, ref double EPS, ref int Range);
        //已知温度(℃)，求饱和水折射率
        [DllImport("IF97", EntryPoint = "T2NL97")]
        public static extern void T2NL97(double T, double LAMD, ref double N, ref int Range);
        //已知温度(℃)，求饱和汽折射率
        [DllImport("IF97", EntryPoint = "T2NG97")]
        public static extern void T2NG97(double T, double LAMD, ref double N, ref int Range);
        //已知温度(℃)，求饱和水表面张力(N/m)
        [DllImport("IF97", EntryPoint = "T2SURFT97")]
        public static extern void T2SURFT97(double T, ref double SURFT, ref int Range);

        //已知温度(℃)和比焓(kJ/kg)，求压力(MPa)(低压的一个值)
        [DllImport("IF97", EntryPoint = "TH2PLP97")]
        public static extern void TH2PLP97(double T, double H, ref double P, ref int Range);
        //已知温度(℃)和比焓(kJ/kg)，求比熵(kJ/(kg.℃))(低压的一个值)
        [DllImport("IF97", EntryPoint = "TH2SLP97")]
        public static extern void TH2SLP97(double T, double H, ref double S, ref int Range);
        //已知温度(℃)和比焓(kJ/kg)，求比容(m^3/kg)(低压的一个值)
        [DllImport("IF97", EntryPoint = "TH2VLP97")]
        public static extern void TH2VLP97(double T, double H, ref double V, ref int Range);
        //已知温度(℃)和比焓(kJ/kg)，求压力(MPa)(高压的一个值)
        [DllImport("IF97", EntryPoint = "TH2PHP97")]
        public static extern void TH2PHP97(double T, double H, ref double P, ref int Range);
        //已知温度(℃)和比焓(kJ/kg)，求比熵(kJ/(kg.℃))(高压的一个值)
        [DllImport("IF97", EntryPoint = "TH2SHP97")]
        public static extern void TH2SHP97(double T, double H, ref double S, ref int Range);
        //已知温度(℃)和比焓(kJ/kg)，求比容(m^3/kg)(高压的一个值)
        [DllImport("IF97", EntryPoint = "TH2VHP97")]
        public static extern void TH2VHP97(double T, double H, ref double V, ref int Range);
        //已知温度(℃)和比焓(kJ/kg)，求压力(MPa)、比熵(kJ/(kg.℃))、比容(m^3/kg)、干度(100%)(低压的一个值)
        [DllImport("IF97", EntryPoint = "THLP97")]
        public static extern void THLP97(ref double P, double T, double H, ref double S, ref double V, ref double X, ref int Range);
        //已知温度(℃)和比焓(kJ/kg)，求压力(MPa)、比熵(kJ/(kg.℃))、比容(m^3/kg)、干度(100%)(高压的一个值)
        [DllImport("IF97", EntryPoint = "THHP97")]
        public static extern void THHP97(ref double P, double T, double H, ref double S, ref double V, ref double X, ref int Range);
        //已知温度(℃)和比焓(kJ/kg)，求压力(MPa)(缺省为低压的一个值)
        [DllImport("IF97", EntryPoint = "TH2P97")]
        public static extern void TH2P97(double T, double H, ref double P, ref int Range);
        //已知温度(℃)和比焓(kJ/kg)，求比熵(kJ/(kg.℃))(缺省为低压的一个值)
        [DllImport("IF97", EntryPoint = "TH2S97")]
        public static extern void TH2S97(double T, double H, ref double S, ref int Range);
        //已知温度(℃)和比焓(kJ/kg)，求比容(m^3/kg)(缺省为低压的一个值)
        [DllImport("IF97", EntryPoint = "TH2V97")]
        public static extern void TH2V97(double T, double H, ref double V, ref int Range);
        //已知温度(℃)和比焓(kJ/kg)，求干度(100%)
        [DllImport("IF97", EntryPoint = "TH2X97")]
        public static extern void TH2X97(double T, double H, ref double X, ref int Range);
        //已知温度(℃)和比焓(kJ/kg)，求压力(MPa)、比熵(kJ/(kg.℃))、比容(m^3/kg)、干度(100%)(缺省为低压的一个值)
        [DllImport("IF97", EntryPoint = "TH97")]
        public static extern void TH97(ref double P, double T, double H, ref double S, ref double V, ref double X, ref int Range);

        //已知温度(℃)和比熵(kJ/(kg.℃))，求压力(MPa)(低压的一个值)
        [DllImport("IF97", EntryPoint = "TS2PLP97")]
        public static extern void TS2PLP97(double T, double S, ref double P, ref int Range);
        //已知温度(℃)和比熵(kJ/(kg.℃))，求比焓(kJ/kg)(低压的一个值)
        [DllImport("IF97", EntryPoint = "TS2HLP97")]
        public static extern void TS2HLP97(double T, double S, ref double H, ref int Range);
        //已知温度(℃)和比熵(kJ/(kg.℃))，求比容(m^3/kg)(低压的一个值)
        [DllImport("IF97", EntryPoint = "TS2VLP97")]
        public static extern void TS2VLP97(double T, double S, ref double V, ref int Range);
        //已知温度(℃)和比熵(kJ/(kg.℃))，求压力(MPa)(高压的一个值)
        [DllImport("IF97", EntryPoint = "TS2PHP97")]
        public static extern void TS2PHP97(double T, double S, ref double P, ref int Range);
        //已知温度(℃)和比熵(kJ/(kg.℃))，求比焓(kJ/kg)(高压的一个值)
        [DllImport("IF97", EntryPoint = "TS2HLH97")]
        public static extern void TS2HHP97(double T, double S, ref double H, ref int Range);
        //已知温度(℃)和比熵(kJ/(kg.℃))，求比容(m^3/kg)(高压的一个值)
        [DllImport("IF97", EntryPoint = "TS2VHP97")]
        public static extern void TS2VHP97(double T, double S, ref double V, ref int Range);
        //已知温度(℃)和比熵(kJ/(kg.℃))，求压力(MPa)(缺省为低压的一个值)
        [DllImport("IF97", EntryPoint = "TS2P97")]
        public static extern void TS2P97(double T, double S, ref double P, ref int Range);
        //已知温度(℃)和比熵(kJ/(kg.℃))，求比焓(kJ/kg)(缺省为低压的一个值)
        [DllImport("IF97", EntryPoint = "TS2H97")]
        public static extern void TS2H97(double T, double S, ref double H, ref int Range);
        //已知温度(℃)和比熵(kJ/(kg.℃))，求比容(m^3/kg)(缺省为低压的一个值)
        [DllImport("IF97", EntryPoint = "TS2V97")]
        public static extern void TS2V97(double T, double S, ref double V, ref int Range);
        //已知温度(℃)和比熵(kJ/(kg.℃))，求干度(100%)
        [DllImport("IF97", EntryPoint = "TS2X97")]
        public static extern void TS2X97(double T, double S, ref double X, ref int Range);
        //已知温度(℃)和比熵(kJ/(kg.℃))，求压力(MPa)、比焓(kJ/kg)、比容(m^3/kg)、干度(100%)(低压的一个值)
        [DllImport("IF97", EntryPoint = "TSLP97")]
        public static extern void TSLP97(ref double P, double T, ref double H, double S, ref double V, ref double X, ref int Range);
        //已知温度(℃)和比熵(kJ/(kg.℃))，求压力(MPa)、比焓(kJ/kg)、比容(m^3/kg)、干度(100%)(高压的一个值)
        [DllImport("IF97", EntryPoint = "TSHP97")]
        public static extern void TSHP97(ref double P, double T, ref double H, double S, ref double V, ref double X, ref int Range);
        //已知温度(℃)和比熵(kJ/(kg.℃))，求压力(MPa)、比焓(kJ/kg)、比容(m^3/kg)、干度(100%)(缺省为低压的一个值)
        [DllImport("IF97", EntryPoint = "TS97")]
        public static extern void TS97(ref double P, double T, ref double H, double S, ref double V, ref double X, ref int Range);

        //已知温度(℃)和比容(m^3/kg)，求压力(MPa)
        [DllImport("IF97", EntryPoint = "TV2P97")]
        public static extern void TV2P97(double T, double V, ref double P, ref int Range);
        //已知温度(℃)和比容(m^3/kg)，求比焓(kJ/kg)
        [DllImport("IF97", EntryPoint = "TV2H97")]
        public static extern void TV2H97(double T, double V, ref double H, ref int Range);
        //已知温度(℃)和比容(m^3/kg)，求比熵(kJ/(kg.℃))
        [DllImport("IF97", EntryPoint = "TV2S97")]
        public static extern void TV2S97(double T, double V, ref double S, ref int Range);
        //已知温度(℃)和比容(m^3/kg)，求干度(100%)
        [DllImport("IF97", EntryPoint = "TV2X97")]
        public static extern void TV2X97(double T, double V, ref double X, ref int Range);
        //已知温度(℃)和比容(m^3/kg)，求压力(MPa)、比焓(kJ/kg)、比熵(kJ/(kg.℃))、干度(100%)
        [DllImport("IF97", EntryPoint = "TV97")]
        public static extern void TV97(ref double P, double T, ref double H, ref double S, double V, ref double X, ref int Range);

        //已知温度(℃)和干度(100%)，求压力(MPa)
        [DllImport("IF97", EntryPoint = "TX2P97")]
        public static extern void TX2P97(double T, double X, ref double P, ref int Range);
        //已知温度(℃)和干度(100%)，求比焓(kJ/kg)
        [DllImport("IF97", EntryPoint = "TX2H97")]
        public static extern void TX2H97(double T, double X, ref double H, ref int Range);
        //已知温度(℃)和干度(100%)，求比熵(kJ/(kg.℃))
        [DllImport("IF97", EntryPoint = "TX2S97")]
        public static extern void TX2S97(double T, double X, ref double S, ref int Range);
        //已知温度(℃)和干度(100%)，求比容(m^3/kg)
        [DllImport("IF97", EntryPoint = "TX2V97")]
        public static extern void TX2V97(double T, double X, ref double V, ref int Range);
        //已知温度(℃)和干度(100%)，求压力(MPa)、比焓(kJ/kg)、比熵(kJ/(kg.℃))、比容(m^3/kg)
        [DllImport("IF97", EntryPoint = "TX97")]
        public static extern void TX97(ref double P, double T, ref double H, ref double S, ref double V, double X, ref int Range);

        //已知比焓(kJ/kg)和比熵(kJ/(kg.℃))，求压力(MPa)
        [DllImport("IF97", EntryPoint = "HS2P97")]
        public static extern void HS2P97(double H, double S, ref double P, ref int Range);
        //已知比焓(kJ/kg)和比熵(kJ/(kg.℃))，求温度(℃)
        [DllImport("IF97", EntryPoint = "HS2T97")]
        public static extern void HS2T97(double H, double S, ref double T, ref int Range);
        //已知比焓(kJ/kg)和比熵(kJ/(kg.℃))，求比容(m^3/kg)
        [DllImport("IF97", EntryPoint = "HS2V97")]
        public static extern void HS2V97(double H, double S, ref double V, ref int Range);
        //已知比焓(kJ/kg)和比熵(kJ/(kg.℃))，求干度(100%)
        [DllImport("IF97", EntryPoint = "HS2X97")]
        public static extern void HS2X97(double H, double S, ref double X, ref int Range);
        //已知比焓(kJ/kg)和比熵(kJ/(kg.℃))，求压力(MPa)、温度(℃)、比容(m^3/kg)、干度(100%)
        [DllImport("IF97", EntryPoint = "HS97")]
        public static extern void HS97(ref double P, ref double T, double H, double S, ref double V, ref double X, ref int Range);

        //已知比焓(kJ/kg)和比容(m^3/kg)，求压力(MPa)
        [DllImport("IF97", EntryPoint = "HV2P97")]
        public static extern void HV2P97(double H, double V, ref double P, ref int Range);
        //已知比焓(kJ/kg)和比容(m^3/kg)，求温度(℃)
        [DllImport("IF97", EntryPoint = "HV2T97")]
        public static extern void HV2T97(double H, double V, ref double T, ref int Range);
        //已知比焓(kJ/kg)和比容(m^3/kg)，求比熵(kJ/(kg.℃))
        [DllImport("IF97", EntryPoint = "HV2S97")]
        public static extern void HV2S97(double H, double V, ref double S, ref int Range);
        //已知比焓(kJ/kg)和比容(m^3/kg)，求干度(100%)
        [DllImport("IF97", EntryPoint = "HV2X97")]
        public static extern void HV2X97(double H, double V, ref double X, ref int Range);
        //已知比焓(kJ/kg)和比容(m^3/kg)，求压力(MPa)、温度(℃)、比熵(kJ/(kg.℃))、干度(100%)
        [DllImport("IF97", EntryPoint = "HV97")]
        public static extern void HV97(ref double P, ref double T, double H, ref double S, double V, ref double X, ref int Range);

        //已知比焓(kJ/kg)和干度(100%)，求压力(MPa)(低压的一个值)
        [DllImport("IF97", EntryPoint = "HX2PLP97")]
        public static extern void HX2PLP97(double H, double X, ref double P, ref int Range);
        //已知比焓(kJ/kg)和干度(100%)，求温度(℃)(低压的一个值)
        [DllImport("IF97", EntryPoint = "HX2TLP97")]
        public static extern void HX2TLP97(double H, double X, ref double T, ref int Range);
        //已知比焓(kJ/kg)和干度(100%)，求比熵(kJ/(kg.℃))(低压的一个值)
        [DllImport("IF97", EntryPoint = "HX2SLP97")]
        public static extern void HX2SLP97(double H, double X, ref double S, ref int Range);
        //已知比焓(kJ/kg)和干度(100%)，求比容(m^3/kg)(低压的一个值)
        [DllImport("IF97", EntryPoint = "HX2VLP97")]
        public static extern void HX2VLP97(double H, double X, ref double V, ref int Range);
        //已知比焓(kJ/kg)和干度(100%)，求压力(MPa)(高压的一个值)
        [DllImport("IF97", EntryPoint = "HX2PLP97")]
        public static extern void HX2PHP97(double H, double X, ref double P, ref int Range);
        //已知比焓(kJ/kg)和干度(100%)，求温度(℃)(高压的一个值)
        [DllImport("IF97", EntryPoint = "HX2THP97")]
        public static extern void HX2THP97(double H, double X, ref double T, ref int Range);
        //已知比焓(kJ/kg)和干度(100%)，求比熵(kJ/(kg.℃))(高压的一个值)
        [DllImport("IF97", EntryPoint = "HX2SHP97")]
        public static extern void HX2SHP97(double H, double X, ref double S, ref int Range);
        //已知比焓(kJ/kg)和干度(100%)，求比容(m^3/kg)(高压的一个值)
        [DllImport("IF97", EntryPoint = "HX2VHP97")]
        public static extern void HX2VHP97(double H, double X, ref double V, ref int Range);
        //已知比焓(kJ/kg)和干度(100%)，求压力(MPa)(缺省是低压的一个值)
        [DllImport("IF97", EntryPoint = "HX2P97")]
        public static extern void HX2P97(double H, double X, ref double P, ref int Range);
        //已知比焓(kJ/kg)和干度(100%)，求温度(℃)(缺省是低压的一个值)
        [DllImport("IF97", EntryPoint = "HX2T97")]
        public static extern void HX2T97(double H, double X, ref double T, ref int Range);
        //已知比焓(kJ/kg)和干度(100%)，求比熵(kJ/(kg.℃))(缺省是低压的一个值)
        [DllImport("IF97", EntryPoint = "HX2S7")]
        public static extern void HX2S7(double H, double X, ref double S, ref int Range);
        //已知比焓(kJ/kg)和干度(100%)，求比容(m^3/kg)(缺省是低压的一个值)
        [DllImport("IF97", EntryPoint = "HX2V7")]
        public static extern void HX2V7(double H, double X, ref double V, ref int Range);
        //已知比焓(kJ/kg)和干度(100%)，求压力(MPa)、温度(℃)、比熵(kJ/(kg.℃))、比容(m^3/kg)(低压的一个值)
        [DllImport("IF97", EntryPoint = "HXLP97")]
        public static extern void HXLP97(ref double P, ref double T, double H, ref double S, ref double V, double X, ref int Range);
        //已知比焓(kJ/kg)和干度(100%)，求压力(MPa)、温度(℃)、比熵(kJ/(kg.℃))、比容(m^3/kg)(高压的一个值)
        [DllImport("IF97", EntryPoint = "HXHP97")]
        public static extern void HXHP97(ref double P, ref double T, double H, ref double S, ref double V, double X, ref int Range);
        //已知比焓(kJ/kg)和干度(100%)，求压力(MPa)、温度(℃)、比熵(kJ/(kg.℃))、比容(m^3/kg)(缺省是低压的一个值)
        [DllImport("IF97", EntryPoint = "HX97")]
        public static extern void HX97(ref double P, ref double T, double H, ref double S, ref double V, double X, ref int Range);

        //已知比熵(kJ/(kg.℃))和比容(m^3/kg)，求压力(MPa)
        [DllImport("IF97", EntryPoint = "SV2P97")]
        public static extern void SV2P97(double S, double V, ref double P, ref int Range);
        //已知比熵(kJ/(kg.℃))和比容(m^3/kg)，求温度(℃)
        [DllImport("IF97", EntryPoint = "SV2T97")]
        public static extern void SV2T97(double S, double V, ref double T, ref int Range);
        //已知比熵(kJ/(kg.℃))和比容(m^3/kg)，求比焓(kJ/kg)
        [DllImport("IF97", EntryPoint = "SV2H97")]
        public static extern void SV2H97(double S, double V, ref double H, ref int Range);
        //已知比熵(kJ/(kg.℃))和比容(m^3/kg)，求干度(100%)
        [DllImport("IF97", EntryPoint = "SV2X97")]
        public static extern void SV2X97(double S, double V, ref double X, ref int Range);
        //已知比熵(kJ/(kg.℃))和比容(m^3/kg)，求压力(MPa)、温度(℃)、比焓(kJ/kg)、干度(100%)
        [DllImport("IF97", EntryPoint = "SV97")]
        public static extern void SV97(ref double P, ref double T, ref double H, double S, double V, ref double X, ref int Range);

        //已知比熵(kJ/(kg.℃))和干度(100%)，求压力(MPa)(低压的一个值)
        [DllImport("IF97", EntryPoint = "SX2PLP97")]
        public static extern void SX2PLP97(double S, double X, ref double P, ref int Range);
        //已知比熵(kJ/(kg.℃))和干度(100%)，求压力(MPa)(中压的一个值)
        [DllImport("IF97", EntryPoint = "SX2PMP97")]
        public static extern void SX2PMP97(double S, double X, ref double P, ref int Range);
        //已知比熵(kJ/(kg.℃))和干度(100%)，求压力(MPa)(高压的一个值)
        [DllImport("IF97", EntryPoint = "SX2PHP97")]
        public static extern void SX2PHP97(double S, double X, ref double P, ref int Range);
        //已知比熵(kJ/(kg.℃))和干度(100%)，求压力(MPa)(缺省是低压的一个值)
        [DllImport("IF97", EntryPoint = "SX2P97")]
        public static extern void SX2P97(double S, double X, ref double P, ref int Range);
        //已知比熵(kJ/(kg.℃))和干度(100%)，求温度(℃)(低压的一个值)
        [DllImport("IF97", EntryPoint = "SX2TLP97")]
        public static extern void SX2TLP97(double S, double X, ref double T, ref int Range);
        //已知比熵(kJ/(kg.℃))和干度(100%)，求温度(℃)(中压的一个值)
        [DllImport("IF97", EntryPoint = "SX2TMP97")]
        public static extern void SX2TMP97(double S, double X, ref double T, ref int Range);
        //已知比熵(kJ/(kg.℃))和干度(100%)，求温度(℃)(高压的一个值)
        [DllImport("IF97", EntryPoint = "SX2THP97")]
        public static extern void SX2THP97(double S, double X, ref double T, ref int Range);
        //已知比熵(kJ/(kg.℃))和干度(100%)，求温度(℃)(缺省是低压的一个值)
        [DllImport("IF97", EntryPoint = "SX2T97")]
        public static extern void SX2T97(double S, double X, ref double T, ref int Range);
        //已知比熵(kJ/(kg.℃))和干度(100%)，求比焓(kJ/kg)(低压的一个值)
        [DllImport("IF97", EntryPoint = "SX2HLP97")]
        public static extern void SX2HLP97(double S, double X, ref double H, ref int Range);
        //已知比熵(kJ/(kg.℃))和干度(100%)，求比焓(kJ/kg)(中压的一个值)
        [DllImport("IF97", EntryPoint = "SX2HMP97")]
        public static extern void SX2HMP97(double S, double X, ref double H, ref int Range);
        //已知比熵(kJ/(kg.℃))和干度(100%)，求比焓(kJ/kg)(高压的一个值)
        [DllImport("IF97", EntryPoint = "SX2HHP97")]
        public static extern void SX2HHP97(double S, double X, ref double H, ref int Range);
        //已知比熵(kJ/(kg.℃))和干度(100%)，求比焓(kJ/kg)(缺省是低压的一个值)
        [DllImport("IF97", EntryPoint = "SX2H97")]
        public static extern void SX2H97(double S, double X, ref double H, ref int Range);
        //已知比熵(kJ/(kg.℃))和干度(100%)，求比容(m^3/kg)(低压的一个值)
        [DllImport("IF97", EntryPoint = "SX2VLP97")]
        public static extern void SX2VLP97(double S, double X, ref double V, ref int Range);
        //已知比熵(kJ/(kg.℃))和干度(100%)，求比容(m^3/kg)(中压的一个值)
        [DllImport("IF97", EntryPoint = "SX2VMP97")]
        public static extern void SX2VMP97(double S, double X, ref double V, ref int Range);
        //已知比熵(kJ/(kg.℃))和干度(100%)，求比容(m^3/kg)(高压的一个值)
        [DllImport("IF97", EntryPoint = "SX2VHP97")]
        public static extern void SX2VHP97(double S, double X, ref double V, ref int Range);
        //已知比熵(kJ/(kg.℃))和干度(100%)，求比容(m^3/kg)(缺省是低压的一个值)
        [DllImport("IF97", EntryPoint = "SX2V97")]
        public static extern void SX2V97(double S, double X, ref double V, ref int Range);
        //已知比熵(kJ/(kg.℃))和干度(100%)，求压力(MPa)、温度(℃)、比焓(kJ/kg)、比容(m^3/kg)(低压的一个值)
        [DllImport("IF97", EntryPoint = "SXLP97")]
        public static extern void SXLP97(ref double P, ref double T, ref double H, double S, ref double V, double X, ref int Range);
        //已知比熵(kJ/(kg.℃))和干度(100%)，求压力(MPa)、温度(℃)、比焓(kJ/kg)、比容(m^3/kg)(中压的一个值)
        [DllImport("IF97", EntryPoint = "SXMP97")]
        public static extern void SXMP97(ref double P, ref double T, ref double H, double S, ref double V, double X, ref int Range);
        //已知比熵(kJ/(kg.℃))和干度(100%)，求压力(MPa)、温度(℃)、比焓(kJ/kg)、比容(m^3/kg)(高压的一个值)
        [DllImport("IF97", EntryPoint = "SXHP97")]
        public static extern void SXHP97(ref double P, ref double T, ref double H, double S, ref double V, double X, ref int Range);
        //已知比熵(kJ/(kg.℃))和干度(100%)，求压力(MPa)、温度(℃)、比焓(kJ/kg)、比容(m^3/kg)(缺省是低压的一个值)
        [DllImport("IF97", EntryPoint = "SX97")]
        public static extern void SX97(ref double P, ref double T, ref double H, double S, ref double V, double X, ref int Range);

        //已知比容(m^3/kg)和干度(100%)，求压力(MPa)(低压的一个值)
        [DllImport("IF97", EntryPoint = "VX2PLP97")]
        public static extern void VX2PLP97(double V, double X, ref double P, ref int Range);
        //已知比容(m^3/kg)和干度(100%)，求压力(MPa)(低高压的一个值)
        [DllImport("IF97", EntryPoint = "VX2PHP97")]
        public static extern void VX2PHP97(double V, double X, ref double P, ref int Range);
        //已知比容(m^3/kg)和干度(100%)，求压力(MPa)(缺省是低压的一个值)
        [DllImport("IF97", EntryPoint = "VX2P97")]
        public static extern void VX2P97(double V, double X, ref double P, ref int Range);
        //已知比容(m^3/kg)和干度(100%)，求温度(℃)(低压的一个值)
        [DllImport("IF97", EntryPoint = "VX2TLP97")]
        public static extern void VX2TLP97(double V, double X, ref double T, ref int Range);
        //已知比容(m^3/kg)和干度(100%)，求温度(℃)(高压的一个值)
        [DllImport("IF97", EntryPoint = "VX2THP97")]
        public static extern void VX2THP97(double V, double X, ref double T, ref int Range);
        //已知比容(m^3/kg)和干度(100%)，求温度(℃)(缺省是低压的一个值)
        [DllImport("IF97", EntryPoint = "VX2T97")]
        public static extern void VX2T97(double V, double X, ref double T, ref int Range);
        //已知比容(m^3/kg)和干度(100%)，求比焓(kJ/kg)(低压的一个值)
        [DllImport("IF97", EntryPoint = "VX2HLP97")]
        public static extern void VX2HLP97(double V, double X, ref double H, ref int Range);
        //已知比容(m^3/kg)和干度(100%)，求比焓(kJ/kg)(高压的一个值)
        [DllImport("IF97", EntryPoint = "VX2HHP97")]
        public static extern void VX2HHP97(double V, double X, ref double H, ref int Range);
        //已知比容(m^3/kg)和干度(100%)，求比焓(kJ/kg)(缺省是低压的一个值)
        [DllImport("IF97", EntryPoint = "VX2H97")]
        public static extern void VX2H97(double V, double X, ref double H, ref int Range);
        //已知比容(m^3/kg)和干度(100%)，求比熵(kJ/(kg.℃))(低压的一个值)
        [DllImport("IF97", EntryPoint = "VX2SLP97")]
        public static extern void VX2SLP97(double V, double X, ref double S, ref int Range);
        //已知比容(m^3/kg)和干度(100%)，求比熵(kJ/(kg.℃))(高压的一个值)
        [DllImport("IF97", EntryPoint = "VX2SHP97")]
        public static extern void VX2SHP97(double V, double X, ref double S, ref int Range);
        //已知比容(m^3/kg)和干度(100%)，求比熵(kJ/(kg.℃))(缺省是低压的一个值)
        [DllImport("IF97", EntryPoint = "VX2S97")]
        public static extern void VX2S97(double V, double X, ref double S, ref int Range);
        //已知比容(m^3/kg)和干度(100%)，求压力(MPa)、温度(℃)、比焓(kJ/kg)、比熵(kJ/(kg.℃))(低压的一个值)
        [DllImport("IF97", EntryPoint = "VXLP97")]
        public static extern void VXLP97(ref double P, ref double T, ref double H, ref double S, double V, double X, ref int Range);
        //已知比容(m^3/kg)和干度(100%)，求压力(MPa)、温度(℃)、比焓(kJ/kg)、比熵(kJ/(kg.℃))(高压的一个值)
        [DllImport("IF97", EntryPoint = "VXHP97")]
        public static extern void VXHP97(ref double P, ref double T, ref double H, ref double S, double V, double X, ref int Range);
        //已知比容(m^3/kg)和干度(100%)，求压力(MPa)、温度(℃)、比焓(kJ/kg)、比熵(kJ/(kg.℃))(缺省是低压的一个值)
        [DllImport("IF97", EntryPoint = "VX97")]
        public static extern void VX97(ref double P, ref double T, ref double H, ref double S, double V, double X, ref int Range);

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
        [DllImport("IF97", EntryPoint = "SF2QM97")]
        public static extern void SF2QM97(ref int PiFtype, double PiTclb, double PiLDclb, double PiSDclb, double PiLagmaLD, double PiLagmaSD, double PiKs, double PiP1, double PiT1, double PiDp, ref double PiQm, ref int Range);

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
        [DllImport("IF97", EntryPoint = "SF2C97")]
        public static extern void SF2C97(ref int PiFtype, double PiTclb, double PiLDclb, double PiSDclb, double PiLagmaLD, double PiLagmaSD, double PiKs, double PiP1, double PiT1, double PiDp, ref double PiC, ref int Range);

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
        [DllImport("IF97", EntryPoint = "SF2A97")]
        public static extern void SF2A97(ref int PiFtype, double PiTclb, double PiLDclb, double PiSDclb, double PiLagmaLD, double PiLagmaSD, double PiKs, double PiP1, double PiT1, double PiDp, ref double PiALpha, ref int Range);
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
        [DllImport("IF97", EntryPoint = "SF2RED97")]
        public static extern void SF2RED97(ref int PiFtype, double PiTclb, double PiLDclb, double PiSDclb, double PiLagmaLD, double PiLagmaSD, double PiKs, double PiP1, double PiT1, double PiDp, ref double PiRED, ref int Range);
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
        [DllImport("IF97", EntryPoint = "CF2QM97")]
        public static extern void CF2QM97(ref int PiFtype, double PiTclb, double PiLDclb, double PiSDclb, double PiLagmaLD, double PiLagmaSD, double PiCxavg, double PiP1, double PiT1, double PiDp, ref double PiQm, ref int Range);
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
        [DllImport("IF97", EntryPoint = "CF2C97")]
        public static extern void CF2C97(ref int PiFtype, double PiTclb, double PiLDclb, double PiSDclb, double PiLagmaLD, double PiLagmaSD, double PiCxavg, double PiP1, double PiT1, double PiDp, ref double PiC, ref int Range);
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
        [DllImport("IF97", EntryPoint = "CF2A97")]
        public static extern void CF2A97(ref int PiFtype, double PiTclb, double PiLDclb, double PiSDclb, double PiLagmaLD, double PiLagmaSD, double PiCxavg, double PiP1, double PiT1, double PiDp, ref double PiALpha, ref int Range);

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
        [DllImport("IF97", EntryPoint = "CF2RED97")]
        public static extern void CF2RED97(ref int PiFtype, double PiTclb, double PiLDclb, double PiSDclb, double PiLagmaLD, double PiLagmaSD, double PiCxavg, double PiP1, double PiT1, double PiDp, ref double PiReD, ref int Range);

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
        [DllImport("IF97", EntryPoint = "DEATANKEQUFLOW97")]
        public static extern void DEATANKEQUFLOW97(double L, double ML, double R, double HS, double HE, double DT, double v, ref double GFlow, ref int Range);

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
        [DllImport("IF97", EntryPoint = "HWBOXEQUFLOW97")]
        public static extern void HWBOXEQUFLOW97(double L, double WT, double WB, double H, double HS, double HE, double DT, double v, ref double GFlow, ref int Range);
        //计算圆柱体热井水位变化的等效流量
        //    已知
        //        R    --> 圆柱体的半径 (米)；
        //        HS   --> 起始水位 (米);
        //        HE   --> 结束水位 (米);
        //        DT   --> 持续时间 (分钟);
        //        V    --> 热井水的平均比容 (m^3/kg);
        //    求
        //        PiQm --> 质量流量 (kg/h)。
        [DllImport("IF97", EntryPoint = "HWCLDEQUFLOW97")]
        public static extern void HWCLDEQUFLOW97(double R, double HS, double HE, double DT, double v, ref double GFlow, ref int Range);

        //******************************************************************************
        //热耗/出力的修正计算
        //采用分段线性插值法
        //UNO-->机组物理编号
        [DllImport("IF97", EntryPoint = "HR_Nel_Crt97")]
        public static extern void HR_Nel_Crt97(int UNO, int PItem, double PIn, ref double POut, ref int Range);
        //计算主汽压力对热耗的修正系数
        [DllImport("IF97", EntryPoint = "PTHR2HR97")]
        public static extern void PTHR2HR97(int UNO, double PIn, ref double POut, ref int Range);
        //计算主汽温度对热耗的修正系数
        [DllImport("IF97", EntryPoint = "TTHR2HR97")]
        public static extern void TTHR2HR97(int UNO, double PIn, ref double POut, ref int Range);
        //计算再热压损对热耗的修正系数
        [DllImport("IF97", EntryPoint = "DPRH2HR97")]
        public static extern void DPRH2HR97(int UNO, double PIn, ref double POut, ref int Range);
        //计算再热温度对热耗的修正系数
        [DllImport("IF97", EntryPoint = "TRH2HR97")]
        public static extern void TRH2HR97(int UNO, double PIn, ref double POut, ref int Range);
        //计算排汽压力对热耗的修正系数
        [DllImport("IF97", EntryPoint = "PEXH2HR97")]
        public static extern void PEXH2HR97(int UNO, double PIn, ref double POut, ref int Range);
        //计算主汽压力对出力的修正系数
        [DllImport("IF97", EntryPoint = "PTHR2NEL97")]
        public static extern void PTHR2NEL97(int UNO, double PIn, ref double POut, ref int Range);
        //计算主汽温度对出力的修正系数
        [DllImport("IF97", EntryPoint = "TTHR2NEL97")]
        public static extern void TTHR2NEL97(int UNO, double PIn, ref double POut, ref int Range);
        //计算再热压损对出力的修正系数
        [DllImport("IF97", EntryPoint = "DPRH2NEL97")]
        public static extern void DPRH2NEL97(int UNO, double PIn, ref double POut, ref int Range);
        //计算再热温度对出力的修正系数
        [DllImport("IF97", EntryPoint = "TRH2NEL97")]
        public static extern void TRH2NEL97(int UNO, double PIn, ref double POut, ref int Range);
        //计算排汽压力对出力的修正系数
        [DllImport("IF97", EntryPoint = "PEXH2NEL97")]
        public static extern void PEXH2NEL97(int UNO, double PIn, ref double POut, ref int Range);
        //计算发电机的机电损失
        [DllImport("IF97", EntryPoint = "NI2DNMG97")]
        public static extern void NI2DNMG97(int UNO, double PIn, ref double POut, ref int Range);
        //排汽环面速度的损失
        [DllImport("IF97", EntryPoint = "VC2DHEXH97")]
        public static extern void VC2DHEXH97(int UNO, double PIn, ref double POut, ref int Range);


        //******************************************************************************
        //已知两个点的X、Y值，线性插值(先输入两个点的X值，再输入两个点的Y值)
        [DllImport("IF97", EntryPoint = "INST2DXX97")]
        public static extern void INST2DXX97(double X1, double X2, double Y1, double Y2, double X, ref double Y);
        //已知两个点的X、Y值，线性插值(先输入一个点的X值和Y值，再输入另外一个点的X值和Y值)
        [DllImport("IF97", EntryPoint = "INST2DXY97")]
        public static extern void INST2DXY97(double X1, double Y1, double X2, double Y2, double X, ref double Y);
    }

}
