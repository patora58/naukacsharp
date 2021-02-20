using System;
using System.Collections.Generic;
using System.Text;

namespace n06_mag_tablice
{
    class Dane
    {
        public const int ROZMIAR = 20;

        public int LicznikTowaru = 0;
        public string[] NazwaTowaru = new string[ROZMIAR];
        public int[] StanTowaru = new int[ROZMIAR];
        public double[] CenaNetto = new double[ROZMIAR];
        public double[] StawkaVat = new double[ROZMIAR];
        public double[] CenaBrutto = new double[ROZMIAR];

        public Dane()
        {
            DodajTowar( "Szczotka", 15, 29.99, 23.0);
            DodajTowar( "Grzebień", 10, 15.00, 7.5);
        }
        public void DodajTowar(string nazwa, int stan, double netto, double vat)
        {
            if (LicznikTowaru < ROZMIAR)
            {   
                NazwaTowaru[LicznikTowaru] = nazwa;
                StanTowaru[LicznikTowaru] = stan;
                CenaNetto[LicznikTowaru] = netto;
                StawkaVat[LicznikTowaru] = vat;
                LicznikTowaru++;
            }
            else
            {
                Console.WriteLine("Brak miejsca!");
            }
        }

    }
}
