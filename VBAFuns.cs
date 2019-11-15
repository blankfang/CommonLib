using System;
using System.Collections.Generic;
using System.Text;

namespace CommonLib
{
    public class VBAFuns
    {

        public static VBAFuns Instance = new VBAFuns();
        private VBAFuns()
        {

        }
        public double  HSE(double h,double s,string  z)
        {
            double x=0;
            double v=0;
            double p=0;
            double t=0;
            z = z.ToLower();
            HS(h, s,out x,out p,out t,out v);
            switch (z)
            {
                case "x":
                    return x;
                case "v":
                    return v;
                case "h":
                    return h;
                case "s":
                    return s;
                case "p":
                    return p;
                case "t":
                    return t;
                default:
                    return double .NaN;
            }

        }
        public double PHE(double p, double h, string z)
        {
            double x = 0;
            double v = 0;
            double t = 0;
            double s = 0;
            z = z.ToLower();
            PH(p, h, out x,out t,out v,out s);
            switch (z)
            {
                case "x":
                    return x;
                case "v":
                    return v;
                case "h":
                    return h;
                case "s":
                    return s;
                case "p":
                    return p;
                case "t":
                    return t;
                default:
                    return double.NaN;
            }
        }
        public double PTE(double p, double t, string z)
        {
            double x = 0;
            double v = 0;
            double h = 0;
            double s = 0;
            z = z.ToLower();
            if (p < 0.01 || p > 1000)
            {
                return double.NaN; //PTE = "压力越界: 0.01<= P <=1000.  bar"
            }
            if (t < 0 || t > 800)
            {
                return double.NaN; //PTE = "温度越界: 0.00<= t <=800. C"
            }
            PT(p, t,out x,out v,out h,out s);

            switch (z)
            {
                case "x":
                    return x;
                case "v":
                    return v;
                case "h":
                    return h;
                case "s":
                    return s;
                case "p":
                    return p;
                case "t":
                    return t;
                default:
                    return double.NaN;
            }
        }
        public double PTGE(double p, double t, string z)
        {
            if (p == 0 || t == 0)
                return double.NaN;
            double v = 0;
            double h = 0;
            double s = 0;
            z = z.ToLower();
            double t1 = TSK(p);
            if (t < t1)
            {
                // "此种状态下，请使用按钮PTL或PT进行计算";
                return double.NaN;
            }
            PTG(p, t, out  v, out h, out s);
            switch (z)
            {
                case "v":
                    return v;
                case "h":
                    return h;
                case "s":
                    return s;
                case "p":
                    return p;
                case "t":
                    return t;
                default:
                    return double.NaN;
            }

        }

        public double PXE(double p, double x, string z)
        {
            double t = 0;
            double v = 0;
            double h = 0;
            double s = 0;
            z = z.ToLower();
            if (p < 0.01 || p >= 221.2)
            {
                return double.NaN; //PXE = "压力越界: 0.01 <= P < 221.2  bar"
            }
            if (x < 0 || x > 1)
            {
                return double.NaN; //PXE = "请注意干度的范围: 0.01= x <=1.0  "
            }
            PX(p, x,out t,out v,out h, out s);
            switch (z)
            {
                case "x":
                    return x;
                case "v":
                    return v;
                case "h":
                    return h;
                case "s":
                    return s;
                case "p":
                    return p;
                case "t":
                    return t;
                default:
                    return double.NaN;

            }
        }
        public double PSE(double p, double s, string z)
        {
            double x = 0;
            double v = 0;
            double h = 0;
            double t = 0;
            z = z.ToLower();
            PS(p, s,out x,out t,out v,out h);
            switch (z)
            {
                case "x":
                    return x;
                case "v":
                    return v;
                case "h":
                    return h;
                case "s":
                    return s;
                case "p":
                    return p;
                case "t":
                    return t;
                default:
                    return double.NaN;

            }
        }
        public double PSKE(double t)
        {
            if (t < 0 || t > 374.15)
            {
                return double.NaN; //PSKE = "温度越界: 0.00<= t <=374.15 C"}
            }
            return PSK(t);
        }

        /// <summary>
        /// 求饱和温度
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public double TSKE(double p)
        {
            if (p > 221.2 || p < 0.01)
            {
                return double.NaN; //TSKE = "压力越界: 0.01<= P <=221.2  bar"
            }
            return TSK(p);
        }

        public void HS(double h, double s,out double x, out double p,out double t,out double v)
        {
            double[] G = new double[6];
            double[] W = new double[5];
            double hg = 0;
            double hf = 0;
            double TB = 0;
            double GF = 0;
            double vg = 0;
            double vf = 0;
            double sg = 0;
            double sf = 0;

            double zh = 0;
            double zs = 0;
            double zt = 0;
            double zp = 0;
            double ts = 0;
            double zhb = 0;
            double zsb = 0;
            double zsa = 0;

            double zha = 0;
            double sa = 0;
            double sb = 0;
            double ha = 0;
            double hb = 0;
            int i = 0;
            int n = 0;
            G[0] = -32230.913;
            G[1] = 16763.0198;
            G[2] = -2684.70102;
            G[3] = 126.015382;
            G[4] = 6.08691173;
            G[5] = -0.515969833;
            W[0] = 0.08275963;
            W[1] = -1.2121626;
            W[2] = -73.61409;
            W[3] = 6.6074894;
            W[4] = -0.4065599;
            hg = 0;

            for (i = 0; i < 6; i++)
            {
                hg = hg + G[i]*Math.Pow(s, i);
            }
            if (h <= hg)
            {
                TB = h/s;
                while (true)
                {

                    GF = 0;
                    for (i = 0; i < 6; i++)
                    {
                        GF = GF + W[i]*Math.Pow((TB*0.01), i);
                    }

                    t = (h - GF)/s - 273.15;
                    if (Math.Abs((t - TB)) < 0.001)
                        break;
                    TB = t;

                }

                p = PSK(t);
                PTG(p, t,out vg,out hg,out sg);
                PTF(p, t,out vf,out hf,out sf);
                x = (h - hf)/(hg - hf);
                v = vf + x*(vg - vf);
                return;
            }
            x = 1;

            zh = h/4186.8;
            zs = 0.238846*s;
            n = 1;
            while (true)
            {
                zt = (Math.Sqrt((0.035081 + 0.085*(zh - 0.4949))) - 0.1873)/0.085;
                zp = Math.Exp(13.064 - 9.072*zs + 3.3982*Math.Log(zt));
                t = 1000*zt - 273.15;
                p = 980.665*zp;
                ts = TSK(p);
                if (t < ts)
                {
                    t = ts;
                    zt = (t + 273.15)/1000;
                    zhb = (Math.Pow((0.085*zt + 0.1873), 2) - 0.035081)/0.085 + 0.4949;
                    zsb = (13.064 - Math.Log(zp) + 3.3982*Math.Log(zt))/9.072;

                }
                else
                {
                    zhb = zh;
                    zsb = zs;
                }

                x = t - ts;
                if (x < 1)
                    x = x + 1;

                PTG(p, t,out v,out hb,out sb);
                if (Math.Abs(h - hb) < 0.0005 && Math.Abs(s - sb) < 0.000001)
                    return;
                if (n <= 1)
                {
                    zh = zhb + 0.0002388*(h - hb);
                    zs = zsb + 0.2388*(s - sb);

                }
                else
                {
                    zh = zhb + (h - hb)*(zhb - zha)/(hb - ha);
                    zs = zsb + (s - sb)*(zsb - zsa)/(sb - sa);
                }
                n = n + 1;
                ha = hb;
                sa = sb;
                zha = zhb;
                zsa = zsb;
                zhb = zh;
                zsb = zs;
            }

        }

        public void PH(double p, double h,out double x,out double t,out double v,out double s)
        {
            double ts;
            double vg;
            double hg;
            double sg;
            double vf;
            double hf;
            double sf;
            double hb;
            double n;
            double zh;
            double zha=0;
            double zhb;
            double zt;
            double ha=0;
            ts = TSK(p);
            PTG(p, ts, out vg, out hg, out sg);
            PTF(p, ts, out vf, out hf, out sf);
            if (h < hf)
            {
                x = 0;
                t = 0.2195*h;
                while (true)
                {
                    PTF(p, t, out v, out hb, out s);
                    x = t - ts;
                    if (Math.Abs(h - hb) < 0.001) return;
                    t = t + 0.238846*(h - hb);
                }
            }
            if (h <= hg)
            {
                t = ts;
                x = (h - hf)/(hg - hf);
                v = vf + x*(vg - vf);
                s = sf + x*(sg - sf);
                return;
            }
            x = 1;
            n = 1;
            zh = h/4186.8;
            while (true)
            {


                zt = (Math.Sqrt(0.035081 + 0.085*(zh - 0.4949)) - 0.1873)/0.085;
                t = 1000*zt - 273.15;
                if (t >= ts)
                {
                    PTG(p, t,out v,out hb,out s);
                    zhb = zh;

                }
                else
                {
                    t = ts;
                    hb = hg;
                    v = vg;
                    s = sg;
                    zt = (273.15 + ts)/1000;

                    zhb = 0.08218 + Math.Pow((0.085*zt + 0.1873), 2)/0.085;
                }
                x = t - ts;
                if (x < 1)
                    x = x + 1;
                if (Math.Abs(h - hb) < 0.001) return;
                if (n <= 1)
                {
                    zh = 0.000238*(h - hb) + zhb;

                }
                else
                {
                    zh = zha + (h - ha)*(zhb - zha)/(hb - ha);
                }
                n = n + 1;
                ha = hb;
                zha = zhb;
                zhb = zh;
            }
        }

        public void PS(double p, double s,out double x,out double t,out double v,out double h)
        {
            double ts;
            double vg;
            double hg;
            double sg;
            double vf;
            double hf;
            double sf;
            double n;
            double zp;
            double zt;
            double zs;
            double sb;
            double zsb;
            double zsa=0;
            double sa=0;
            ts = TSK(p);
            PTG(p, ts, out vg, out hg, out sg);
            PTF(p, ts, out vf, out hf, out sf);
            if (s >= sf && s > sg)
            {

                x = 1;
                n = 1;
                zp = p/980.7;
                zs = 0.238846*s;
                while (true)
                {


                    zt = (zs - 1.44)*1.1594*Math.Log(10) + 0.25381*1.1594*Math.Log(zp);
                    zt = Math.Exp(zt);
                    t = 1000*zt - 273.15;
                    if (t >= ts)
                    {
                        PTG(p, t, out v, out h, out sb);
                        zsb = zs;

                    }
                    else
                    {
                        t = ts;
                        sb = sg;
                        v = vg;
                        h = hg;
                        zt = (273.15 + t)/1000;
                        zsb = (Math.Log(zt)/1.1594 - 0.25381*Math.Log(zp))/Math.Log(10) + 1.44;
                    }
                    x = t - ts;
                    if (x < 1)
                        x = x + 1;
                    if (Math.Abs(s - sb) <= 0.00000005) return;

                    if (n > 1)
                    {
                        zs = zsb + (s - sb)*(zsb - zsa)/(sb - sa);

                    }
                    else
                    {
                        zs = zsb + 0.1672*(s - sb);
                    }
                    n = n + 1;
                    sa = sb;
                    zsa = zsb;
                }

            }
            if (s > sg)
            {
                x = 0;
                t = 89.85*s;
                while (true)
                {
                    PTF(p, t, out v, out h, out sb);
                    x = t - ts;
                    if (Math.Abs(s - sb) <= 0.0000005) return;
                    t = t + 89.85*(s - sb);
                }
            }
            x = (s - sf)/(sg - sf);
            t = ts;
            v = vf + x*(vg - vf);
            h = hf + x*(hg - hf);
            return;
        }
        public double PSK(double t)
        {
            double[] F = new double[10];
            double zt, ZTT, PK;
            int ik, i;

            F[0] = 0; //0#
            F[1] = -7.691234564;
            F[2] = -26.08023696;
            F[3] = -168.1706546;
            F[4] = 64.23285504;
            F[5] = -118.9646225;
            F[6] = 4.16711732;
            F[7] = 20.9750676;
            F[8] = 1000000000; //#;
            F[9] = 6; //6#;
            zt = (t + 273.15) / 647.3;
            ZTT = 1 - zt;
            PK = 0; //#
            for (ik = 1; ik < 7; ik++)
            {
                i = 7 - ik;
                PK = PK * ZTT + F[i-1];
            }
            PK = PK / zt / (1 /*#*/+ F[6] * ZTT + F[7] * Math.Pow(ZTT, 2));
            PK = PK - ZTT / (F[8] * Math.Pow(ZTT, 2) + F[9]);
            return Math.Exp(PK) * 221.2;

        }

        public void PT(double p, double t, out double x, out double v, out double h, out double s)
        {
            double ts;
            v = h = s = double.NaN;

            ts = TSK(p);
            x = t - ts;
            if (x < 0)
            {
                PTF(p, t, out v, out h, out s);
            }
            else if (x > 0)
            {
                PTG(p, t, out v, out h, out s);
                if (x >= 1) return;
                x = x + 1;
            }
            else
            {
                //Form1.Label12.Caption = "  是饱和状态  "'
            }
        }
        public void PTF(double p, double t, out  double v, out  double h, out double s)
        {
            double[] A = new double[23];
            double[] E = new double[12];

            //Dim A[1 To 23] As Double, E[1 To 12] As Double
            //Dim zp As Double, zt As Double, Y As Double, z As Double, zv As Double
            //Dim YP As Double, zh As Double, gg As Double, zs As Double
            //Dim i As Integer, ik As Integer
            double zp, zt, Y, z, zv;
            double YP, zh, gg, zs;
            int i, ik;

            A[0] = 6824.687741;
            A[1] = -542.2063673;
            A[2] = -20966.66205;
            A[3] = 39412.86787;
            A[4] = -67332.77739;
            A[5] = 99023.81028;
            A[6] = -109391.1774;
            A[7] = 85908.41667;
            A[8] = -45111.68742;
            A[9] = 14181.38926;
            A[10] = -2017.271113;
            A[11] = 7.982692717;
            A[12] = -0.02616571843;
            A[13] = 0.00152241179;
            A[14] = 0.02284279054;
            A[15] = 242.1647003;
            A[16] = 1.269716088E-10;
            A[17] = 2.074838328E-07;
            A[18] = 2.17402035E-08;
            A[19] = 1.105710498E-09;
            A[20] = 12.93441934;
            A[21] = 0.00001308119072;
            A[22] = 6.047626338E-14;
            E[0] = 0.8438375405;
            E[1] = 0.0005362162162;
            E[2] = 1.72;
            E[3] = 0.07342278489;
            E[4] = 0.0497585887;
            E[5] = 0.65371543;
            E[6] = 0.00000115;
            E[7] = 0.000015108;
            E[8] = 0.14188;
            E[9] = 7.002753165;
            E[10] = 0.0002995284926;
            E[11] = 0.204;

            //比容的计算
            zp = p / 221.2;
            zt = (273.15 + t) / 647.3;
            Y = 1 - E[0] * Math.Pow(zt, 2) - E[1] / Math.Pow(zt, 6);
            z = Y + Math.Pow((E[2] * Math.Pow(Y, 2) - 2 * E[3] * zt + 2 * E[4] * zp), 0.5);
            zv = A[11] * E[4] / Math.Pow(z, 0.2941176);
            zv = zv + A[12] + A[13] * zt + A[14] * Math.Pow(zt, 2) + A[15] * Math.Pow((E[5] - zt), 10);
            zv = zv + A[16] / (E[6] + Math.Pow(zt, 19));
            zv = zv - (A[17] + 2 * A[18] * zp + 3 * A[19] * Math.Pow(zp, 2)) / (E[7] + Math.Pow(zt, 11));
            zv = zv - A[20] * Math.Pow(zt, 18) * (E[8] + Math.Pow(zt, 2)) * (-3 / Math.Pow((E[9] + zp), 4) + E[10]);
            zv = zv + 3 * A[21] * (E[11] - zt) * Math.Pow(zp, 2) + 4 * A[22] / Math.Pow(zt, 20) * Math.Pow(zp, 3);
            v = 0.00317 * zv;

            // 焓值的计算
            YP = 6 * E[1] / Math.Pow(zt, 7) - 2 * E[0] * zt;
            zh = 0;
            for (ik = 1; ik <= 10; ik++)
            {
                i = 11 - ik;
                zh = zh*zt + (i - 2)*A[i];
            }
            gg = z * (17 * (z / 29 - Y / 12) + 5 * zt * YP / 12);
            gg = gg + E[3] * zt - (E[2] - 1) * zt * YP * Y;
            zh = A[0] * zt - zh + A[11] * gg / Math.Pow(z, 0.2941176);
            gg = A[12] - A[14] * Math.Pow(zt, 2) + A[15] * (9 * zt + E[5]) * Math.Pow((E[5] - zt), 9);
            gg = gg + A[16] * (20 * Math.Pow(zt, 19) + E[6]) / Math.Pow((E[6] + Math.Pow(zt, 19)), 2);
            zh = zh + gg * zp;
            gg = 12 * Math.Pow(zt, 11) + E[7];
            gg = gg * (A[17] * zp + A[18] * Math.Pow(zp, 2) + A[19] * Math.Pow(zp, 3));
            zh = zh - gg / Math.Pow(E[7] + Math.Pow(zt, 11), 2);
            gg = A[20] * Math.Pow(zt, 18) * (17 * E[8] + 19 * Math.Pow(zt, 2));
            gg = gg * (1 / Math.Pow((E[9] + zp), 3) + E[10] * zp);
            zh = zh + gg;
            zh = zh + A[21] * E[11] * Math.Pow(zp, 3) + 21 * A[22] * Math.Pow(zp, 4) / Math.Pow(zt, 20);
            h = zh * 70.1204;


            //熵值的计算
            zs = 0;
            for (ik = 2; ik <= 10; ik++)
            {
                i = 12 - ik;
                zs = zs * zt + (i - 1) * A[i];
            }

            gg = A[11] * ((5 * z / 12 - (E[2] - 1) * Y) * YP + E[3]) / Math.Pow(z, 0.2941176);
            zs = A[0] * Math.Log(zt) - zs + gg;
            gg = -A[13] - 2 * A[14] * zt + 10 * A[15] * Math.Pow((E[5] - zt), 9);
            gg = (gg + 19 * A[16] * Math.Pow(zt, 18) / Math.Pow((E[6] + Math.Pow(zt, 19)), 2)) * zp;
            zs = zs + gg;
            gg = A[17] * zp + A[18] * Math.Pow(zp, 2) + A[19] * Math.Pow(zp, 3);
            zs = zs - 11 * Math.Pow(zt, 10) * gg / Math.Pow((E[7] + Math.Pow(zt, 11)), 2);
            gg = A[20] * (18 * E[8] + 20 * Math.Pow(zt, 2));
            zs = zs + gg * (E[10] * zp + 1 / Math.Pow((E[9] + zp), 3)) * Math.Pow(zt, 17);
            zs = zs + A[21] * Math.Pow(zp, 3) + 20 * A[22] * Math.Pow(zp, 4) / Math.Pow(zt, 21);
            s = 108.3275143 * zs / 1000;

        }
        public void PTG(double p, double t, out double v, out double h, out double s)
        {
            double[] B0 = new double[5];
            double[] B9 = new double[7];
            double[,] BUV = new double[8, 3];
            double[,] ZUV = new double[8, 3];
            double[,] XUL = new double[3, 3];
            double[,] BUL = new double[3, 3];
            double L0;
            double L1;
            double L2;
            double B;
            double B1;
            double C1;
            double zp;
            double zt;
            double z6;
            double zs;
            double bl;
            double blp;
            double x;
            double z0;
            double z1;
            double z2;
            double z3 = 0;
            double z4;
            double z5;

            int i;
            int ii;
            int j;
            int ik;
            int k;

            double zv;
            double gg;
            double zh;
            B0[0] = 28.56067796;
            B0[1] = -54.38923329;
            B0[2] = 0.4330662834;
            B0[3] = -0.6547711697;
            B0[4] = 0.08565182058;
            B9[0] = 193.6587558;
            B9[1] = -1388.522425;
            B9[2] = 4126.607219;
            B9[3] = -6508.211677;
            B9[4] = 5745.984054;
            B9[5] = -2693.088365;
            B9[6] = 523.5718623;

            BUV[0, 0] = 0.06670375918;
            BUV[1, 0] = 0.08390104328;
            BUV[2, 0] = 0.4520918904;
            BUV[3, 0] = -0.5975336707;
            BUV[4, 0] = 0.5958051609;
            BUV[5, 0] = 0.119061027;
            BUV[6, 0] = 0.1683998803;
            BUV[7, 0] = 0.006552390126;
            
            BUV[0, 1] = 1.388983801;
            BUV[1, 1] = 0.02614670893;
            BUV[2, 1] = 0.1069036614;
            BUV[3, 1] = -0.08847535804;
            BUV[4, 1] = -0.5159303373;
            BUV[5, 1] = -0.09867174132;
            BUV[6, 1] = -0.05809438001;
            BUV[7, 1] = 0.0005710218649;

            BUV[0, 2] = 0;
            BUV[1, 2] = -0.03373439453;
            BUV[2, 2] = 0;
            BUV[3, 2] = 0;
            BUV[4, 2] = 0.2075021122;
            BUV[5, 2] = 0;
            BUV[6, 2] = 0;
            BUV[7, 2] = 0;
            
            ZUV[0, 0] = 13;
            ZUV[1, 0] = 18;
            ZUV[2, 0] = 18;
            ZUV[3, 0] = 25;
            ZUV[4, 0] = 32;
            ZUV[5, 0] = 12;
            ZUV[6, 0] = 24;
            ZUV[7, 0] = 24;

            ZUV[0, 1] = 3;
            ZUV[1, 1] = 2;
            ZUV[2, 1] = 10;
            ZUV[3, 1] = 14;
            ZUV[4, 1] = 28;
            ZUV[5, 1] = 11;
            ZUV[6, 1] = 18;
            ZUV[7, 1] = 14;


            ZUV[0, 2] = 0;
            ZUV[1, 2] = 1;
            ZUV[2, 2] = 0;
            ZUV[3, 2] = 0;
            ZUV[4, 2] = 24;
            ZUV[5, 2] = 0;
            ZUV[6, 2] = 0;
            ZUV[7, 2] = 0;


            XUL[0, 0] = 14;
            XUL[1, 0] = 19;
            XUL[2, 0] = 54;
            
            XUL[0, 1] = 0;
            XUL[1, 1] = 0;
            XUL[2, 1] = 27;


            XUL[0, 2] = 0;
            XUL[1, 2] = 0;
            XUL[2, 2] = 0;


            BUL[0, 0] = 0.4006073948;
            BUL[1, 0] = 0.08636081627;
            BUL[2, 0] = -0.8532322921;
          
            BUL[0, 1] = 0;
            BUL[1, 1] = 0;
            BUL[2, 1] = 0.3460208861;
            
            BUL[0, 2] = 0;
            BUL[1, 2] = 0;
            BUL[2, 2] = 0;
                       

            L0 = 15.74373327;
            L1 = -34.17061978;
            L2 = 19.31380707;
            B = 0.7633333333;
            B1 = 16.83599274;
            C1 = 4.260321148;
            //比容的计算
            zp = p / 221.2;
            zt = (273.15 + t) / 647.3;
            bl = L0 + L1 * zt + L2 * Math.Pow(zt, 2);
            blp = L1 + 2 * L2 * zt;
            x = Math.Exp(B * (1 - zt));
            z1 = 0;


            for (i = 1; i < 6; i++)
            {
                z2 = 0;
                for (j = 1; j < 4; j++)
                    z2 = z2 + BUV[i - 1, j - 1] * Math.Pow(x, ZUV[i - 1, j - 1]);
                z1 = z1 + z2 * i * Math.Pow(zp, (i - 1));
            }
            z4 = 0;

            for (i = 1; i < 4; i++)
            {
                z2 = 0;
                z3 = 0;
                for (j = 1; j < 4; j++)
                {
                    z2 = z2 + BUV[i + 4, j - 1] * Math.Pow(x, ZUV[i + 4, j - 1]);
                    z3 = z3 + BUL[i - 1, j - 1] * Math.Pow(x, XUL[i - 1, j - 1]);
                }
                z4 = z4 + z2 * (i + 3) * Math.Pow(zp, (i + 2)) / Math.Pow((1 + z3 * Math.Pow(zp, (i + 3))), 2);
            }
            z6 = 0;
            if (zp >= 0.1)
            {
                for (ik = 1; ik < 8; ik++)
                {
                    i = 8 - ik;
                    z6 = z6 * x + B9[i - 1];
                }
                z6 = 11 * z6 * Math.Pow((zp / bl), 10);
            }
            zv = C1 * zt / zp - z1 - z4 + z6;
            v = 0.00317 * zv;
            //'焓值的计算
            z0 = 0;
            for (ik = 1; ik < 6; ik++)
            {
                i = 6 - ik;
                z0 = z0 * zt + (i - 2) * B0[i - 1];
            }
            z1 = 0;


            for (i = 1; i < 6; i++)
            {
                z2 = 0;

                for (j = 1; j < 4; j++)
                {
                    z2 = z2 + BUV[i - 1, j - 1] * (1 + B * ZUV[i - 1, j - 1] * zt) * Math.Pow(x, ZUV[i - 1, j - 1]);
                }
                z1 = z1 + z2 * Math.Pow(zp, i);
            }
            z5 = 0;


            if (zp >= 0.005)
            {
                for (i = 1; i < 4; i++)
                {
                    z4 = 0;
                    for (j = 1; j < 4; j++)
                    {
                        z2 = 0;
                        z3 = 0;
                        for (k = 1; k < 4; k++)
                        {
                            z2 = z2 + XUL[i - 1, k - 1] * BUL[i - 1, k - 1] * Math.Pow(x, XUL[i - 1, k - 1]);
                            z3 = z3 + BUL[i - 1, k - 1] * Math.Pow(x, XUL[i - 1, k - 1]);
                        }
                        gg = 1 + ZUV[i + 4, j - 1] * B * zt - B * zt * z2 / (z3 + 1 / Math.Pow(zp, (i + 3)));
                        z4 = BUV[i + 4, j - 1] * Math.Pow(x, ZUV[i + 4, j - 1]) * gg + z4;
                    }
                    z5 = z5 + z4 / (z3 + 1 / Math.Pow(zp, (i + 3)));
                }
            }
            z6 = 0;


            if (zp >= 0.1)
            {
                for (ik = 1; ik < 8; ik++)
                {
                    i = 8 - ik;
                    z6 = z6 * x + B9[i - 1] * (1 + zt * (10 * blp / bl + B * (i - 1)));
                }
                z6 = z6 * zp * Math.Pow((zp / bl), 10);

            }
            zh = B1 * zt - z0 - z1 - z5 + z6;
            h = zh * 70.1204;
            //'熵值的计算
            z0 = 0;

            for (ii = 1; ii < 6; ii++)
            {
                i = 6 - ii;
                z0 = z0 * zt + (i - 1) * B0[i - 1];
            }
            z0 = z0 / zt;
            z1 = 0;

            for (i = 1; i < 6; i++)
            {
                for (j = 1; j < 4; j++)
                    z1 = z1 + B * Math.Pow(zp, i) * ZUV[i - 1, j - 1] * BUV[i - 1, j - 1] * Math.Pow(x, ZUV[i - 1, j - 1]);

            }
            z5 = 0;

            if (zp >= 0.005)
            {
                for (i = 1; i < 4; i++)
                {
                    z4 = 0;

                    for (j = 1; j < 4; j++)
                    {
                        z2 = 0;
                        z3 = 0;
                        for (k = 1; k < 4; k++)
                        {
                            z2 = z2 + Math.Pow(x, XUL[i - 1, k - 1]) * BUL[i - 1, k - 1] * XUL[i - 1, k - 1];
                            z3 = z3 + BUL[i - 1, k - 1] * Math.Pow(x, XUL[i - 1, k - 1]);
                        }
                        gg = ZUV[i + 4, j - 1] - z2 / (1 / Math.Pow(zp, (i + 3) + z3));
                        z4 = z4 + gg * BUV[i + 4, j - 1] * Math.Pow(x, ZUV[i + 4, j - 1]);
                    }
                    z5 = z5 + z4 / (1 / Math.Pow(zp, (i + 3)) + z3);
                }
            }
            z5 = B * z5;
            z6 = 0;

            if (zp >= 0.1)
            {
                for (ik = 1; ik < 8; ik++)
                {
                    i = 8 - ik;
                    z6 = z6 * x + (10 * blp / bl + B * (i - 1)) * B9[i - 1];
                }
                z6 = z6 * zp * Math.Pow((zp / bl), 10);
            }
            zs = B1 * Math.Log(zt) - C1 * Math.Log(zp) - z0 - z1 - z5 + z6;
            s = 108.3275143 * zs / 1000;

        }
        public void PX(double p, double x,out double t, out double v, out double h, out double s)
        {
            double vf;
            double vg;
            double hf;
            double hg;
            double sf;
            double sg;

            t = TSK(p);
            PTF(p, t, out vf, out hf, out sf);
            PTG(p, t, out vg, out hg, out sg);
            v = vf + x*(vg - vf);
            h = hf + x*(hg - hf);
            s = sf + x*(sg - sf);
        }

        public double TSK(double p)
        {
            ///原文是100#
            double TA = 100 * Math.Pow(p, 0.25);
            double PB = PSK(TA);

            while (Math.Abs((p - PB) / p) >= 0.0000001)
            {
                TA = TA + 25 * (p - PB) / Math.Pow(PB, 0.75);
                PB = PSK(TA);
            }
            return TA;

        }
        
        public double PTLE(double p, double t, string z)
        {
            if (p == 0 || t == 0)
                return double.NaN;
            double v, h, s;
            // z = LCase(z]
            double t1 = TSK(p);
            t1 = TSK(p);
            if (t > t1+0.11)
                return double.NaN;// "此种状态下，请使用按钮PTG或PT进行计算";
            PTF(p, t, out v, out  h, out s);
            switch (z.ToLower())
            {
                case "v":
                    return v;
                case "h":
                    return h;
                case "s":
                    return s;
                case "p":
                    return p;
                case "t":
                    return t;
                default:
                    return double.NaN;
            }
        }

       

       

        

    }
}
