using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _248
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your choice // 1 or 2");
            byte x = byte.Parse(Console.ReadLine());
            if (x == 1)
                Console.WriteLine("Pay bills");
            if (x == 2)
            {
                Console.WriteLine("Pay bills");
                Console.WriteLine("reduction of traffic ");
            }
        }
    }
}
