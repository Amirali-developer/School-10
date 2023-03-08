using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _267
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your device");
            string x = Console.ReadLine();
            switch (x)
            {
                case "keyborad":
                case "Mouse":
                case "Scanner":
                    Console.WriteLine("{0} is input device ", x);
                    break;
                case "Monitor":
                case "Printer":
                case "Headphone":
                    Console.WriteLine("{0} is output device ", x);
                    break;
                case "Modem":
                case "Network card":
                case "Audio Card":
                    Console.WriteLine("{0} is Both Input–OutPut Devices ", x);
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
