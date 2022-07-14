using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clal_HW
{

    public static class Logger
    {
      

        public static void WriteInfo(string type, string mathod, string msg)
        {
            Console.WriteLine(type + ": mathod:" + mathod + "; ex:" + msg);
        }
        public static void Write(string msg)
        {
            Console.WriteLine(msg);
        }


    }
}
