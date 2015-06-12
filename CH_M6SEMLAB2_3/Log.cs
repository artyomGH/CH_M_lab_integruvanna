using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH_M6SEMLAB2_3
{
    public class Log
    {
        private StreamWriter file { get; set; }

        public Log(string filepath)
        {
            file = new StreamWriter(filepath);
        }
        
        public void WriteText(string str)
        {
            file.Write("{0,11}", str);            
        }
        public void WriteText(double str)
        {
            file.Write("{0,11}", Math.Round(str,3));
        }

        public void Commit()
        {
            file.Close();
        }
    }
}
