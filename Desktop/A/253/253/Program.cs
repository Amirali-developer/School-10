using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _253
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" How old are you");
            bool result = int.TryParse(Console.ReadLine(), out int age);
            if (result)
            {
                string s = (age = 18 ? "Allowed" : "Not Allowed");
                Console.WriteLine(s);
            }
        }
    }
}
