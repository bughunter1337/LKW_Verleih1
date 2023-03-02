using System;
using System.Collections.Generic;
using System.Text;

namespace LKW_Verleih
{
    class Menue
    {
        public void Menue_anzeigen()
        { 
            Console.Clear();   //ConsolenFenster wird "geleert"
            Console.WriteLine("______________________________");   // einfache textausgabe auf dem Consolenfenster
            Console.WriteLine("           _Menü_");
            Console.WriteLine("______________________________");
            Console.WriteLine("Neuen Kunden eingeben      <1>");
            Console.WriteLine("Alle Kunden ausgeben       <2>");
            Console.WriteLine("Neues Fahrzeug eingeben    <3>");
            Console.WriteLine("Alle Fahrzeuge ausgeben    <4>");
            Console.WriteLine("Eine Buchung Eingeben      <5>");
            Console.WriteLine("Buchungen Abrechnen        <6>");
            Console.WriteLine("Buchungen Ausgeben         <7>");
            Console.WriteLine("Speicherstand Einlesen     <8>");
            Console.WriteLine("Stand abspeichern          <9>");
            Console.WriteLine("t/t/ geschrieben von KaanKuzey c://iah81/kuzey");


        }


    }
}
