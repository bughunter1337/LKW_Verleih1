using System;
using System.Collections.Generic;
using System.Text;

namespace LKW_Verleih
{
    class Kunde : Kundi
    {
        ConsoleKeyInfo taste;
        private char AcMitglied;
        private string sGebDatum;
        private int i = 0;

        private DateTime GebDatum;
        public override void Person_aufnehmen()
        {
            Console.WriteLine("Kundendaten    :");
            Console.WriteLine("----------------");
            Console.Write("Name           :"); sName = Console.ReadLine();
            Console.Write("Vorname        :"); sVorname = Console.ReadLine();
            Console.Write("GeburtsDatum   :"); GebDatum = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Email-Adresse  :"); sEmail = Console.ReadLine();
            Console.WriteLine("FührerSchein?");
            Console.WriteLine("Ja <j>  Nein <n>");
            taste = Console.ReadKey(true);
            switch (taste.KeyChar)
            {
                case 'j':
                    FührerSchein = 'j';
                    break;
                case 'n':
                    FührerSchein = 'n';
                    break;
            }
            Console.WriteLine("AutomobilClub Mitglied?");
            Console.Write("Ja <j>  Nein <n>");
            taste = Console.ReadKey();
            switch (taste.KeyChar)
            {
                case 'j':
                    AcMitglied = 'j';
                    break;
                case 'n':
                    AcMitglied = 'n';
                    break;
            }

        }

        public override void Person_ausgeben()
        {
            sGebDatum = GebDatum.Day + "." + GebDatum.Month + "." + GebDatum.Year;
            Console.Write("Name:{0}, Vorname:{1}, Geb. Datum:{2}, Email-Adresse:{3}, FuehrerSchein: ",
            sName, sVorname, sGebDatum, sEmail);
            if( FührerSchein=='j')
            {
                Console.Write("ja");
            }
            else
            {
                Console.Write("nein **Kunde ist ungeeignet**");
            }

            Console.Write("Automobil-Club mitglied:");
            if (AcMitglied=='j')
            {
                Console.WriteLine("ja **5% Mitglieder Rabatt**");
            }
            else
            {
                Console.WriteLine("nein");
            }
        }
        public override void Schubladen_oeffnerK(string st1, string st2, string st3, string st4, string st5, string st6)
        {
            sName = st1;
            sVorname = st2;
            GebDatum = Convert.ToDateTime(st3);
            sEmail = st4;
            FührerSchein = Convert.ToChar(st5);
            AcMitglied = Convert.ToChar(st6);
        }
        public override string Datt_gebK()
        {
            string auss = "k";

            if (i > 2)
            {
                auss = sName;
            }
            if (i > 3)
            {
                auss = sVorname;
            }
            if (i > 4)
            {
                auss = GebDatum.Day + "." + GebDatum.Month + "." + GebDatum.Year;
            }
            if (i > 5)
            {
                auss = sEmail;
            }
            if (i > 6)
            {
                auss = Convert.ToString(FührerSchein);
            }
            if (i > 7)
            {
                auss = Convert.ToString(AcMitglied);
            }
            return auss;
        }


    }

}
