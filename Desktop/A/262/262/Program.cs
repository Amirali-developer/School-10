using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _262
{
    class Program
    {
        static void Main(string[] args)
        {
            if (season == "Bahar")
                Console.WriteLine("Farvardin, Ordibehesht, Khordad");
            else if (season == "Tabestan")
                Console.WriteLine("Tir, Mordad, Shahrivar");
            else if (season == "Paeiz")
                Console.WriteLine("Mehr, Aban, Azar");
            else if (season == "Zemestan")
                Console.WriteLine("Dey, Bahman, Esfand");
            else
                Console.WriteLine("Season Wrong");
        }
    }
}
