using System;
using System.Collections.Generic;
using System.Text;

namespace n09_mag_gui
{
    class Dane
    {
        public const int ROZMIAR = 20;

        private int LicznikTowaru = 0;
        private Towar[] Towary = new Towar[ROZMIAR];

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
                throw new Exception("Brak miejsca!");
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

        public List<Towar> PodajTowary()
        {
            List<Towar> lista = new List<Towar>();
            for (int i = 0; i < LicznikTowaru; i++)
            {
                Towar t = Towary[i];
                lista.Add(t);
            }
            return lista;
        }
    }
}
