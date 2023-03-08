using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _239
{
    class Program
    {
        static void Main(string[] args)
        {

            byte x, y;
            y = byte.Parse(Console.ReadLine());
            x = byte.Parse(Console.ReadLine());
            Console.WriteLine((x == 2) || (y == 5));

        }
    }
}
