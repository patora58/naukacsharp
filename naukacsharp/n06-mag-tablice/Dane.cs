using System;
using System.Collections.Generic;
using System.Text;

namespace n06_mag_tablice
{
    class Dane
    {
        public int LicznikTowaru = 0;
        public string[] NazwaTowaru = new string[20];
        public int[] StanTowaru = new int[20];
        public double[] CenaNetto = new double[20];
        public double[] StawkaVat = new double[20];
        public double[] CenaBrutto = new double[20];

        public Dane()
        {
            NazwaTowaru[0] = "Szczotka";
            StanTowaru[0] = 15;
            CenaNetto[0] = 29.99;
            StawkaVat[0] = 23.0;
            LicznikTowaru++;

            NazwaTowaru[1] = "Grzebień";
            StanTowaru[1] = 10;
            CenaNetto[1] = 15.00;
            StawkaVat[1] = 7.5;
            LicznikTowaru++;

        }
        public void DodajTowar(string nazwa, int stan, double netto, double vat)
        {
            NazwaTowaru[LicznikTowaru] = nazwa;
            StanTowaru[LicznikTowaru] = stan;
            CenaNetto[LicznikTowaru] = netto;
            StawkaVat[LicznikTowaru] = vat;
            LicznikTowaru++;
        }
    }
}
