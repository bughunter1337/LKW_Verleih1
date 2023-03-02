using System;
using System.Collections.Generic;
using System.Text;

namespace LKW_Verleih
{
    abstract class Auti
    {
        protected double kmstand, dMietPreis;
        protected string sKennZeichen, Marke;

        public abstract void Auto_eingeben();

        public abstract void Autos_Ausgeben();

        public abstract double Preis_Geben();

        public abstract double Km_Geben();

        public abstract void Schubladen_oeffnerA(string st1, string st2, string st3, string st4, string st5, string st6, string st7);

        public abstract string Datt_gebA();
    }
}
