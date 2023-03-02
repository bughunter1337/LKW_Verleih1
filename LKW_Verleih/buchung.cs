using System;
using System.Collections.Generic;
using System.Text;

namespace LKW_Verleih
{
    class buchung
    {
        private Auti EinAuto;
        private Kundi EinKunde;
        private double dAPreis, dEPreis, kmstamd, Kelometa;
        private int a, k,i=0;


        public buchung(Auti Autt, Kundi Kundd, int e, int f)
        {
            dEPreis = 30.00;
            EinAuto = Autt;
            EinKunde = Kundd;
            a = e;
            k = f;
        }
        public void Buchung_abrechnen()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("    *Abrechnung*");
            Console.WriteLine("--------------------");
            Console.WriteLine("     *Eingabe*");
            Console.WriteLine("Aktueller Km stand :"); kmstamd = Convert.ToDouble(Console.ReadLine());
            
            Kelometa = EinAuto.Km_Geben();
            dAPreis = EinAuto.Preis_Geben();
            dEPreis = dEPreis + ((kmstamd - Kelometa) * dAPreis);

            Console.Write("Endgebühr :", dEPreis); 

        }
        public void Bugungen_Ausgeben()
        {
            Console.WriteLine("--------------------");
            EinKunde.Person_ausgeben();
            EinAuto.Autos_Ausgeben();
            Console.WriteLine("--------------------");
        }
        public string Datt_gebB()
        {
            string auss = " ";
            if(i>1)
            {
                auss = Convert.ToString(a);
            }
            if(i>2)
            {
                auss = Convert.ToString(k);
            }
            i++;
            return auss;
        }
    }
}
