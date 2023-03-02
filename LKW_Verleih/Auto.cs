using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace LKW_Verleih
{
    class Auto : Auti
    {
        private int iTuerzahl, iKofferraumVolumen;
        private int i = 0;
        
        
        public override void Auto_eingeben()
        {
            kmstand = 0.00;
            dMietPreis = 0.90;
            Console.WriteLine("  **##Autodaten##**  ");
            Console.WriteLine("---------------------");
            Console.WriteLine("Mietpreis {0}/km", dMietPreis);
            Console.WriteLine("---------------------");
            Console.WriteLine("      _Eingabe_      ");
            Console.Write("TürAnzahl  :"); iTuerzahl = Convert.ToInt32(Console.ReadLine());
            Console.Write("KofferraumVolumen:"); iKofferraumVolumen = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kennzeichen  :"); sKennZeichen = Console.ReadLine();
            Console.WriteLine("Marke"); Marke = Console.ReadLine();

        }
        public override void Autos_Ausgeben()
        {
            Console.Write("{0}, {1}, {2}, {3}, {4}, {5}, " , kmstand, iTuerzahl, iKofferraumVolumen, sKennZeichen, Marke);
        }
        public override double Preis_Geben()
        {
            return dMietPreis;
        }
        public override double Km_Geben()
        {
            return kmstand;
        }
        public override void Schubladen_oeffnerA(string st1, string st2, string st3, string st4, string st5, string st6, string st7)
        {
            kmstand = Convert.ToDouble(st1);
            iTuerzahl = Convert.ToInt32(st2);
            iKofferraumVolumen = Convert.ToInt32(st3);
            sKennZeichen = st4;
            Marke = st5;
            dMietPreis = Convert.ToDouble(st6);
        }
        public override string Datt_gebA()
        {
            string auss = "a";

            if (i > 2)
            {
                auss = Convert.ToString(kmstand);
            }
            if (i > 3)
            {
                auss = Convert.ToString(iTuerzahl);
            }
            if (i > 4)
            {
                auss = Convert.ToString(iKofferraumVolumen);
            }
            if (i > 5)
            {
                auss = sKennZeichen;
            }
            if (i > 6)
            {
                auss = Marke;
            }
            if (i > 7)
            {
                auss = Convert.ToString(dMietPreis);
            }
            i++;
            return auss;
        }
    }
}
