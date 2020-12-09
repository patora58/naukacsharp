using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n02_hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write ("podaj imie: ");
            string imie = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Witaj, " + imie+"!");
            Console.ReadLine();

        }
    }
}
