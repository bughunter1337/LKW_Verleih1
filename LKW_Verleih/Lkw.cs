using System;
using System.Collections.Generic;
using System.Text;

namespace LKW_Verleih
{
    class Lkw : Auti
    {

        private int iLadevolumen, iSchleppGewicht, i=0;
        
        public override void Auto_eingeben()
        {
            kmstand = 0.00;
            dMietPreis = 0.50;
            Console.WriteLine("  **##Autodaten##**  ");
            Console.WriteLine("---------------------");
            Console.WriteLine("Mietpreis {0}/km", dMietPreis);
            Console.WriteLine("---------------------");
            Console.WriteLine("      _Eingabe_      ");
            Console.Write("Km stand            :"); kmstand = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kennzeichen         :"); sKennZeichen = Console.ReadLine();
            Console.Write("Marke               :"); Marke = Console.ReadLine();
            Console.Write("Max. Ladevolumen?    :"); iLadevolumen = Convert.ToInt32(Console.ReadLine());
            Console.Write("Max. Schleppgewicht? :"); iSchleppGewicht = Convert.ToInt32(Console.ReadLine());
        }
        public override void Autos_Ausgeben()
        {
            Console.Write("{0}, {1}, {2}, {3}, {4}, ", kmstand, sKennZeichen, Marke, iLadevolumen, iSchleppGewicht);
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
            sKennZeichen = st2;
            Marke = st3;
            iLadevolumen = Convert.ToInt32(st4);
            iSchleppGewicht = Convert.ToInt32(st5);
            
        }
        public override string Datt_gebA()
        {
            string auss = " ";
            if (i > 2)
            {
                auss = Convert.ToString(kmstand);
            }
            if (i > 3)
            {
                auss = sKennZeichen;
            }
            if (i > 4)
            {
                auss = Marke;
            }
            if (i > 5)
            {
                auss = Convert.ToString(iLadevolumen);
            }
            if (i > 6)
            {
                auss = Convert.ToString(iSchleppGewicht);
            }
            i++;
            return auss;
        }
    }
}
