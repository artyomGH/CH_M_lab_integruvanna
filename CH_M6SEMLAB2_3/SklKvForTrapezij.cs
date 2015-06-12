using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH_M6SEMLAB2_3
{
    class SklKvForTrapezij
    {
        double a=5,b=7,y0, yn, h,eps=0.0001;
        
        public double calculate(int n)
        {
            double suma = 0;
            double x=a,tmp=eps+1;
            double h=0;
            //for(;Math.Abs( tmp)>eps;)
            //{                
            //    
            //    tmp = -(b - a) / 12 * h * h * pohidna;
            //    n++;
            //}
            h = (b - a) / n;
            Console.WriteLine(n);
            for(int i=1;i<n-1;i++)
            {
                x += h;
                suma += formula(x);
            }
            suma += (formula(a) + formula(b)) / 2;
            suma = suma * h;
            return suma;
        }
        public static double formula(double x)
        {
            double res = 0;
            res = x * Math.Cos(x * x) + Math.Log10(x*x*x) / Math.Log10(Math.E);
            return res;
        }
    }
}
