using System;
using System.Collections.Generic;
using System.Text;

namespace n08_mag_obiekty
{
    class Dane
    {
        public const int ROZMIAR = 20;

        public int LicznikTowaru = 0;
        public Towar[] Towary = new Towar[ROZMIAR];

        public Dane()
        {
            DodajTowar("Szczotka", 15, 29.99, 23.0);
            DodajTowar("Grzebień", 10, 15.00, 7.5);
        }
        public void DodajTowar(string nazwa, int stan, double netto, double vat)
        {
            Towar nowy = new Towar(nazwa, stan, netto, vat);
            DodajTowar(nowy);
        }
        public void DodajTowar(Towar nowy)
        {
            if (LicznikTowaru < ROZMIAR)
            {
                Towary[LicznikTowaru] = nowy;
                LicznikTowaru++;
            }
            else
            {
                Console.WriteLine("Brak miejsca!");
            }
        }
        public void PoliczBrutto()
        {
            for (int i = 0; i < LicznikTowaru; i++)
            {
                PoliczBrutto(Towary[i]);
            }
        }

        private void PoliczBrutto(Towar towar)
        {
            towar.PoliczCeneBrutto();      
        }

        public void WyswietlTowary()
        {
            for (int i = 0; i < LicznikTowaru; i++)
            {
                Towar t = Towary[i];
                Console.WriteLine($"{i}. {t.NazwaTowaru} "
                    + $"\t Stan: {t.StanTowaru}"
                    + $"\t netto: {t.CenaNetto}"
                    + $"\t Vat: {t.StawkaVat}%"
                    + $"\t Brutto: {t.CenaBrutto}");
            }
        }
    }
}
