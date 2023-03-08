using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _232_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool result = true;
            Console.WriteLine(result > 0);
            string s1 = "Ali";
            string s2 = "Reza";
            s1 += s2;
            s1 = s1 - s2;
            float f = 100 - s1;
            s1 = -s1;
        }
    }
}
