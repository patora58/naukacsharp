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

        /*
        === komentarz wieloliniowy - START ===
        |
        |  Opis: Poprzednia wersja funkcji CzteryLiczbySrednia()
        |  Autor: Wiktor
        |  Data: 20.12.2020
        |
        ===
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
            liczba4 = WczytajInt("4 liczbe");   // komentarz 1-liniowy

        }

        === komentarz wieloliniowy - KONIEC ===
        */

        private static void CzteryLiczbySrednia()
        {
            // 4 zmienne lokalne, deklaracje z przypisaniem - do wczytania wartości
            int liczba1 = WczytajInt("1 liczbe");
            int liczba2 = WczytajInt("2 liczbe");
            int liczba3 = WczytajInt("3 liczbe");
            int liczba4 = WczytajInt("4 liczbe");

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
