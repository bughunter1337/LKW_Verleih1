using System;
using System.Collections.Generic;
using System.Text;

namespace LKW_Verleih
{
    class Eingabe //ungenutzte Klasse 
    {
        public static bool JaNein()
        {
            bool JN = false;
            Console.Write("Ja=j Nein=n ");
            if (Convert.ToChar(Console.ReadKey()) == 'j')
            {
                JN = true;
            }
            else JN = false;
            return JN;
        }
        public static string sEingebung()
        {
            string Eingabe = "euh";



            return Eingabe;
        }
    }
}
