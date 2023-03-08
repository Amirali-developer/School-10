using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _234_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            Console.WriteLine("Enter num1 : ");
            num1 = int.Parse(Console.ReadLine());
            num1++;
            num1 * 5;
            --num1;
            num1 / 2;
            Console.WriteLine("num1={0} ", num1);
            Console.ReadKey();
        }
    }
}
