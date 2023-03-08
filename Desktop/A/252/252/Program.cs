using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _252
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());
            string s;
            s = (age >= 18 ? "Allowed" : " Not Allowed");
            Console.WriteLine(s);
        }
    }
}
