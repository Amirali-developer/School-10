using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _258
{
    class Program
    {
        static void Main(string[] args)
        {
            if (temp > 19)
                if (condition == "sunny")
                    Console.WriteLine("Excellent");


            if ((temp > 19) && (condition == "sunny"))
                Console.WriteLine("Excellent");


            if (temp < 19)
            {
                if (condition == "sunny")
                    Console.WriteLine("suitable");
                if (condition == "partly cloudy ")
                    Console.WriteLine("suitable");
            }
        }
    }
}
