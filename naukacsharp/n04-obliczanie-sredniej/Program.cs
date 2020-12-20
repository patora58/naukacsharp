using System;

namespace n04_obliczanie_sredniej
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OBLICZANIE ŚREDNIEJ");

            ProstaKonwersjaLiczbNapisow();
            CzteryLiczbySrednia();

            Console.ReadLine();
        }

        private static void ProstaKonwersjaLiczbNapisow()
        {
            int x = 13;
            string s = x.ToString();
            int y = int.Parse(s);

            if (x == y)
                Console.WriteLine("x jest rowny y");
            else
                Console.WriteLine("x oraz y sa ROZNE");
        }

        private static void CzteryLiczbySrednia()
        {
            // Deklaracje 4 zmiennych lokalnych, bez wartości początkowych
            int liczba1;
            int liczba2;
            int liczba3;
            int liczba4;

            Console.Write("Podaj 1 liczbe: ");
            string str1 = Console.ReadLine();
            liczba1 = Convert.ToInt32(str1);

            Console.Write("Podaj 2 liczbe: ");
            string str2 = Console.ReadLine();
            liczba2 = Convert.ToInt32(str2);

            Console.Write("Podaj 3 liczbe: ");
            string str3 = Console.ReadLine();
            liczba3 = Convert.ToInt32(str3);

            Console.Write("Podaj 4 liczbe: ");
            string str4 = Console.ReadLine();
            liczba4 = Convert.ToInt32(str4);

            double srednia = (liczba1 + liczba2 + liczba3 + liczba4) / 4.0;
            Console.WriteLine("Srednia liczb = " + srednia);
        }
    }
}
