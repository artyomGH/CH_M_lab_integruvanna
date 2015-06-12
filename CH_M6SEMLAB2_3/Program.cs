using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH_M6SEMLAB2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double res = 0;
            int n = 0;
            SklKvForTrapezij tr = new SklKvForTrapezij();
            Console.WriteLine("vedit n ");
            n = Convert.ToInt32(Console.ReadLine());
            if(n==-1)
                res = tr.calculate(928760);
            else
                res = tr.calculate(n);
            Console.WriteLine(res);
            
            Log l=new Log("D:\\tmp\\lab1\\log_lab1PramokutTrap.txt");
            
            PramokutTrap ptr = new PramokutTrap();
            double eps=0;
            Console.WriteLine("vedit eps ");
            string str = "";
            str = Console.ReadLine();
            eps=Convert.ToDouble(str);
            res = ptr.calculate(l,eps);
            l.Commit();

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}