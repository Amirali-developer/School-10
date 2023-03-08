using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _242
{
    class Program
    {
        static void Main(string[] args)
        {

            //A
            Console.Write("Enter num1:");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter num2:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(" {0} greater than{1} ـ} <2}", num1, num2, num1 > num2);
            Console.WriteLine(" {0} less than {1} ـ} <2}", num1, num2, num1 < num2);
            Console.WriteLine(" {0} equal to {1} ـ} <2}", num1, num2, num1 == num2);
            Console.WriteLine("{0} not equal to {1} ـ} <2}", num1, num2, num1 != num2);

            //B
            Console.WriteLine("Enter an integer:");
            int myInt = int.Parse(Console.ReadLine());
            bool isLessThan10 = myInt < 10;
            bool isBetween0And5 = (0 <= myInt) && (myInt <= 5);
            Console.WriteLine("Integer less than 10? {0}", isLessThan10);
            Console.WriteLine("Integer between 0 and 5? {0}", isBetween0And5);
        }
    }
}
