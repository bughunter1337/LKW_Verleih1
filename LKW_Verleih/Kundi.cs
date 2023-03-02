using System;
using System.Collections.Generic;
using System.Text;

namespace LKW_Verleih
{
    abstract class Kundi
    {
        protected string sName, sVorname, sEmail;
        protected char FührerSchein;


        public abstract void Person_aufnehmen();
        public abstract void Person_ausgeben();
        public abstract void Schubladen_oeffnerK(string st1, string st2, string st3, string st4, string st5, string st6);

        public abstract string Datt_gebK();

    }
}
