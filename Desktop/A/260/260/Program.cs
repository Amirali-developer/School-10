using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _260
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            if (b + c > a) count++;
            if (a + c > b) count++;
            if (a + b > c) count++;
            if (count == 3)
                Console.WriteLine(true);
            else
                Console.WriteLine(false);
        }
    }
}
