using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _257
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the air temperature");
            int temp = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the weather conditions: sunny /cloudy / partly cloudy/ rainy");
            string condition = Console.ReadLine();
        }
    }
}
