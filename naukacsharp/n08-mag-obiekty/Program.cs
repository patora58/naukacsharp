using System;

namespace n08_mag_obiekty
{
    class Program
    {
        static void Main(string[] args)
        {
            Towar t1 = new Towar();
            t1.NazwaTowaru = "Szczotka1";
            t1.StanTowaru = 15;
            t1.CenaNetto = 319.99;
            t1.StawkaVat = 23.0;

            Towar t2 = new Towar {
                NazwaTowaru = "Grzebień1",
                StanTowaru = 10,
                CenaNetto = 115.00,
                StawkaVat = 7.5 
            };

            Towar t3 = new Towar("Miska", 20, 24.50, 23.0);

            Dane Magazyn = new Dane();
            Magazyn.DodajTowar(t1);
            Magazyn.DodajTowar(t2);
            Magazyn.DodajTowar(t3);

            Magazyn.PoliczBrutto();
            Magazyn.WyswietlTowary();
        }
    }
}
