using System;

namespace n06_mag_tablice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Magazyn - tablice");
            Dane magazyn = new Dane();
            magazyn.DodajTowar("Miska", 9, 10.00, 23.0);
            magazyn.DodajTowar("Zabawka", 20, 5, 7.5);
            PoliczBrutto(magazyn);
            Wyswietl(magazyn);

        }

        private static void PoliczBrutto(Dane magazyn)
        {
            for (int i = 0; i < magazyn.LicznikTowaru; i++)
            {
                magazyn.CenaBrutto[i] = magazyn.CenaNetto[i]
                * (1.0 + magazyn.StawkaVat[i] / 100.0); 
            }
        }

        private static void Wyswietl(Dane magazyn)
        {
            for (int i = 0; i<magazyn.LicznikTowaru; i++)
            {
                Console.WriteLine($"{i}. {magazyn.NazwaTowaru[i]} "
                    + $"\t Stan: {magazyn.StanTowaru[i]}"
                    + $"\t netto: {magazyn.CenaNetto[i]}"
                    +$"\t Vat: {magazyn.StawkaVat[i]}%"
                    +$"\t Brutto: {magazyn.CenaBrutto[i]}"); 
            }
        }
    }
}
