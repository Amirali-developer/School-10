using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _261
{
    class Program
    {
        static void Main(string[] args)
        {
            if (a + b <= c)
                Console.WriteLine(false);
            else if (a + c <= b)
                Console.WriteLine(false);
            else if (b + c <= a)
                Console.WriteLine(false);
            else
                Console.WriteLine(true);
        }
    }
}
