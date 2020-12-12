using System;

namespace n03_następna
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Następna liczba");
            //1. pobranie liczby od użytkownika
            Console.Write("podaj liczbe: ");
            string odpowiedz = Console.ReadLine();
            int podana = Convert.ToInt32(odpowiedz);
            //2. wywołanie funkcji do określenia nastepnej lczby nieparzystej
            int nieparzysta = NastepnaNieparzysta(podana);
            //3. wywołanie funkcji do określenia nastepnej lczby parzystej
            int parzysta = NastepnaParzysta(podana);
            //4. wyświetlenie wyników
            Console.WriteLine("nieparzysta=" + nieparzysta);
            Console.WriteLine("parzysta=" + parzysta);

            //Console.ReadLine();
        }

        static int NastepnaParzysta(int liczba)
        {
            int wynik = liczba;
            if (liczba % 2 == 0)
            {
                wynik = wynik + 2;
            }
            else
            {
                wynik = wynik + 1;
            }

            return wynik;
           

        }

        static int NastepnaNieparzysta(int liczba)
        {
            int wynik = liczba;
            if (liczba % 2 == 0)
            {
               wynik = wynik + 1;
            }
            else
            {
                wynik = wynik + 2;
            }

            return wynik;
        }

        


    }
}
