using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _251_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the floor");
            int floor = int.Parse(Console.ReadLine());
            if (floor % 2 == 0)
                Console.WriteLine("Elevator A");
            else
                Console.WriteLine("Elevator B");
        }
    }
}
