using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedRain
{
    class CHelper
    {
        public static void Log(string s, string file)
        {
            using (StreamWriter sw = new StreamWriter(file, true))
            {
                sw.WriteLine("[---" + DateTime.Now + "---]" + Environment.NewLine + s + Environment.NewLine + "[-------------------------]" + Environment.NewLine);
                sw.Close();
            }
        }
    }
}
