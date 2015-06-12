using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH_M6SEMLAB2_3
{
    class PramokutTrap
    {
        int n = 1;
        double b=7, a=5;
        Log log;
        public double calculate(Log l,double eps)
        {
            log = l;
            int stop = 0;
            double H = b - a;
            double 
                I_T_H = 0,
                I_T_h=0,
                I_P_H=0,
                R_T_h=0,
                I_C_h=0,
                h,x1,x,y,suma_y=0;
            log.WriteText("n");

            log.WriteText("I_T_H");
            log.WriteText("I_P_H");
            log.WriteText("I_T_h");
            log.WriteText("R_T_h");
            log.WriteText(Environment.NewLine);
            I_T_H = H / 2 * (formula(a) + formula(b));
            for (; stop == 0; )
            {
                suma_y = 0;
                h = H / 2;
                x1 = a + h;
                suma_y += formula(x1);
                for (int i = 2; i <= n; i++)
                {
                    x = x1 + H;
                    y = formula(x);
                    suma_y += y;
                    x1 = x;
                }
                I_P_H = H * suma_y;
                I_T_h = 0.5 * (I_P_H + I_T_H);
                R_T_h = (double)1 / 3 * (I_T_h - I_T_H);

                log.WriteText(n);
                log.WriteText(I_T_H);
                log.WriteText(I_P_H);
                log.WriteText(I_T_h);
                log.WriteText(R_T_h);
                log.WriteText(Environment.NewLine);

                if (Math.Abs(R_T_h) > eps)
                {
                    n = 2 * n;
                    H = h;
                    I_T_H = I_T_h;
                }
                else
                    stop = 1;
            }
            I_C_h = I_T_h + R_T_h;
            log.WriteText("Остаточний результат: ");
            log.WriteText(Environment.NewLine);
            log.WriteText(I_C_h);
            return I_C_h;
        }
        public static double formula(double x)
        {
            double res = 0;
            res = x * Math.Cos(x * x) + Math.Log10(x * x * x) / Math.Log10(Math.E);
            return res;
        }
    }
}
