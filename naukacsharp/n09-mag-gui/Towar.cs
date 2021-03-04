using System;
using System.Collections.Generic;
using System.Text;

namespace n09_mag_gui
{
    class Towar
    {
        public string NazwaTowaru;
        public int StanTowaru;
        public double CenaNetto;
        public double StawkaVat;
        public double CenaBrutto;

        public Towar()
        {
        }

        public Towar(string nazwaTowaru, int stanTowaru, double cenaNetto, double stawkaVat)
        {
            NazwaTowaru = nazwaTowaru;
            StanTowaru = stanTowaru;
            CenaNetto = cenaNetto;
            StawkaVat = stawkaVat;
            PoliczCeneBrutto();
        }

        public void PoliczCeneBrutto()
        {
            CenaBrutto = CenaNetto * (1.0 + StawkaVat / 100.0);
        }

        public override string ToString()
        {
            return $"{NazwaTowaru} "
                    + $"\t Stan: {StanTowaru}"
                    + $"\t netto: {CenaNetto}"
                    + $"\t Vat: {StawkaVat}%"
                    + $"\t Brutto: {CenaBrutto}";
        }
    }
}
