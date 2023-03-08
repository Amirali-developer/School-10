using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _235
{
    class Program
    {
        static void Main(string[] args)
        {
            int booklet, children;
            Console.WriteLine("Enter number of booklet : ");
            booklet = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of children : ");
            children = int.Parse(Console.ReadLine());
            int count = booklet / children;
            Console.WriteLine("count={0} ", count);
            Console.ReadKey();
        }
    }
}
