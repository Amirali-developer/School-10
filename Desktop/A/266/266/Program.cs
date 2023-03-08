using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _266
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What’s your favorite color?");
            Console.WriteLine("[r] red");
            Console.WriteLine("[g] green");
            Console.WriteLine("[b] blue");
            Console.WriteLine("[w] white");
            Console.WriteLine("[y] yellow");
            Console.Write(" Enter your choice: ");
            char choice = char.Parse(Console.ReadLine());
            switch (choice)
            {
                case ' r ':
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Clear();
                    break;
                case ' g ':
                    ـــــــ
                    ـــــــ
             ـــــــ
             case ' b ':
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Clear();
                    break;
                default:
                    ـــــــ
                    ـــــــ
             ـــــــ
            }
        }
    }
}
