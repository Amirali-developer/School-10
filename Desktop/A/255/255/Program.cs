using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _255
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your user name");
            string user = Console.ReadLine();
            Console.WriteLine("Enter your password");
            string pass = Console.ReadLine();
            if (user == "reza")
                if (pass == "123456")
                    Console.WriteLine("Welcome " + user);
                else
                    Console.WriteLine("The password is incorrect");
            else
                Console.WriteLine("Unkown user");
            Console.ReadKey();
        }
    }
}
