using System;
using System.Collections.Generic;
using System.Text;

namespace n08_mag_obiekty
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
    }
}
