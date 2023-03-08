using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _229
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("count of students class 102={0} ", count102++);
            Console.WriteLine("count of students class 102={0} ", ++count102);

            int x = 12, y = -12;
            Console.WriteLine("x={0} y={1}", x++, ++y);
            Console.WriteLine("x={0} y={1}", --x, ++y);
            y = ++x;
            x = y--;
            Console.WriteLine("x={0} y={1}", x, y);
        }
    }
}
