using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _227
{
    class Program
    {
        static void Main(string[] args)
        {
            int count101, count102;
            Console.Write("Enter count of student class 101:");
            count101 = int.Parse(Console.ReadLine());
            Console.Write("Enter count of student class 102:");
            count102 = int.Parse(Console.ReadLine());
            Console.WriteLine("count of students class 101={0} ", count101--);
            Console.WriteLine("count101={0} ", count101);
            Console.WriteLine("count of students class 102={0} ", count102++);
            Console.WriteLine("count102={0} ", count102);
        }
    }
}
