using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static string Main(string[] args)
        {
            int a = 12;
            int b = 9;
            string Result;
                Result = (a == b ? "sim" : "não");
            return(Result);

            Console.ReadKey();
        }
    }
}
