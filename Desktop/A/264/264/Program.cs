using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _264
{
    class Program
    {
        static void Main(string[] args)
        {
            long x = long.Parse(Console.ReadLine());
            x = x % 10;
            switch (x)
            {
                case 1:
                    Console.WriteLine("5");
                    break;
                case 2:
                    Console.WriteLine("3");
                    break;
                    ـــــــــ
            case 9:
                    Console.WriteLine("7");
                    break;
                case 0:
                    Console.WriteLine("9");
                    break;
            }
        }
    }
}
