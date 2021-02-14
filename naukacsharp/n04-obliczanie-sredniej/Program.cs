using System;

namespace n04_obliczanie_sredniej
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OBLICZANIE ŚREDNIEJ");

            //ProstaKonwersjaLiczbNapisow();
            //CzteryLiczbySrednia();

            //SredniaCiaguLiczbZakonczonychZerem();

            SredniaCiaguLiczbZTablicy();

            Console.ReadLine();
        }

        // 1. Pętla czytająca kolejną liczbę
        // 2. Jeśli wczytane zero, koniec pętli
        // 3. W przeciwnym przypadku: zapisaie wczytanej liczby do tablicy
        // 4. Zwiększenie ilości wczytanych liczb
        // 5. Po zakończeniu pętli: obliczenie i wyświetlenie średniej

        const int MAXL = 5;
        private static void SredniaCiaguLiczbZTablicy()
        {
            int[] tablica = new int[MAXL];        // utworzenie tablicy

            //1.
            int ilosc = 0;
            while (ilosc < tablica.Length)
            {
                Console.Write("Podaj " + ilosc + " liczbe: ");
                String napis = Console.ReadLine();
                int liczba = int.Parse(napis);

                //2.
                if (liczba == 0)
                    break;
                //3.
                tablica[ilosc] = liczba;
                //4.
                ilosc++;
            }
            // 5.
            ObliczOrazWyswietlSredniaDlaTablicy(tablica, ilosc);

        }
        
        private static void ObliczOrazWyswietlSredniaDlaTablicy(int[] tablica, int ilosc)
        {
            int suma;
            suma = 0;

            // 5. 
            for (int pozycja = 0; pozycja < ilosc; ++pozycja)
            {
                Console.WriteLine($"  [{pozycja}] = " + tablica[pozycja]);
                suma = suma + tablica [pozycja];
            }

            if (ilosc > 0)
            {
                double Srednia = 1.0 * suma / ilosc;  //automatyczna konwersja typów, co znaczy że po double trzeba zadeklarować 1.0 by wymusić przecinkowość w wyświetlanej liczbie!!!
                Console.WriteLine($"obliczona srednia wynosi {Srednia} ");
            }
            else
            {
                Console.WriteLine(" nie da sie obliczyc sredniej");
            }                
          
            Console.WriteLine("obliczona suma wynosi " + suma);   
        }

        // 0. Potrzebne: suma oraz ilość wczytywanych liczb
        // 1. Pętla czytająca kolejną liczbę
        // 2. Jeśli wczytane zero, koniec pętli
        // 3. W przeciwnym przypadku: sumowanie wczytanej liczby z dotychczasowymi
        // 4. Zwiększenie licznika wczytanych liczb
        // 5. Po zakończeniu pętli: obliczenie i wyświetlenie średniej
        // 5* Co jeśli ilość wczytanych liczb jest równa zero???

        // 3 4 0        => 3.5
        // 4 6 0        => 5.0
        // 2 0          => 2.0
        // 1 2 3 4 5    => 3.0
        // 0            => ? (INFINITY) NaN => Not A Number
        private static void SredniaCiaguLiczbZakonczonychZerem()
        {
            // 0.
            int suma = 0;
            int ilosc = 0;
            int liczba = 0;

            // for   do..while   while    foreach
            while (true)   // pętla nieskończona
            {
                // 1.
                liczba = WczytajInt("ciag liczb zakonczony '0'");
                // 2.
                if (liczba == 0)  // warunek stopu pętli
                    break;
                else
                {
                    // 3.
                    suma = suma + liczba;
                    // 4.
                    ilosc = ilosc + 1;
                }
            };

            // 5.
            if (ilosc > 0)
            {
                double srednia = (suma * 1.0) / ilosc;
                Console.WriteLine("Srednia liczb = " + srednia);
            }
            else
            {
                // 5*
                Console.WriteLine("Podano pusty ciag liczb");
            }
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
