using System;
using System.Collections.Generic;
using System.Text;

namespace LKW_Verleih
{
    class Firma_Kunde : Kundi
    {

        private string sFirma, sNummerschild;
        private int i = 0;


        public override void Person_aufnehmen()
        {

            Console.WriteLine("Mitgliedsdaten : ");
            Console.WriteLine("----------------");
            Console.Write("FirmaName?     :"); sFirma = Console.ReadLine();
            Console.Write("Name           :"); sName = Console.ReadLine();
            Console.Write("Vorname        :"); sVorname = Console.ReadLine();
            Console.Write("Email-Adresse  :"); sEmail = Console.ReadLine();
            Console.Write("Nummerschild   :"); sNummerschild = Console.ReadLine();

        }
        public override void Person_ausgeben()
        {
            Console.WriteLine("FirmaName:{0}, Name:{1}, Vorname{2}, Email-Aresse:{3}, NummernSchild:{4} ",
               sFirma, sName, sVorname, sEmail, sNummerschild);
            

        }
        public override void Schubladen_oeffnerK(string st1, string st2, string st3, string st4, string st5, string st6)
        {
            sFirma = st1;
            sName = st2;
            sVorname = st3;
            sEmail = st4;
            sNummerschild = st5;
        }
        public override string Datt_gebK()
        {
            string auss = " ";
            if (i > 2)
            {
                auss = sFirma;
            }
            if (i > 3)
            {
                auss = sName;
            }
            if (i > 4)
            {
                auss = sVorname;
            }
            if (i > 5)
            {
                auss = sEmail;
            }
            if (i > 6)
            {
                auss = sNummerschild;
            }
            i++;
            return auss;
        }

    }
}
