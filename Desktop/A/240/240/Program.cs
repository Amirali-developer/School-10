using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _240
{
    class Program
    {
        static void Main(string[] args)
        {
            string weather;
            Console.WriteLine(" weather:");
            weather = Console.ReadLine();
            Console.WriteLine("weather is not cloudy: {0}", weather != "cloudy");
        }
    }
}
