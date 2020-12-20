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

            liczba1 = WczytajInt("1 liczbe");
            liczba2 = WczytajInt("2 liczbe");
            liczba3 = WczytajInt("3 liczbe");
            liczba4 = WczytajInt("4 liczbe");

            double srednia = (liczba1 + liczba2 + liczba3 + liczba4) / 4.0;
            Console.WriteLine("Srednia liczb = " + srednia);
        }

        private static int WczytajInt(string opis)
        {
            Console.Write("Podaj " + opis + ": ");
            string str = Console.ReadLine();
            int wczytana = int.Parse(str);
            return wczytana;
        }
    }
}
