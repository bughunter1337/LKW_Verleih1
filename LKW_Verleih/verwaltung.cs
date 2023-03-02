using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace LKW_Verleih
{
    class verwaltung
    {
        private int iKunde, iAuto;   // benutzt für die buchung
        private int iKundzahl, iAutozahl, iBuchzahl; // Globale Zählervariablen für die arrayverwaltung

        private buchung[] Mieten;
        private Kundi[] Mitglied;
        private Auti[] Autoos;

        public verwaltung()   // der konstruktor
        {
            Autoos = new Auti[100];      //den Arrays wird platz zugewiesen
            Mitglied = new Kundi[100];
            Mieten = new buchung[100];
        }

        public void Mitglied_aufnehmen()      // Methode um kunden hinzuzufügen
        {
            Console.WriteLine("\n\n\n - Zur KundenDatenEingabe");      
            Console.WriteLine("\n       <P>rivatKunde oder <F>irmaKunde");

            ConsoleKeyInfo taste;
            taste = Console.ReadKey(true); // die entscheidung welche der verfügbaren kinderklassen erzeugt werden
            switch (taste.KeyChar)
            {
                case 'p':
                    Mitglied[iKundzahl] = new Kunde();
                    Mitglied[iKundzahl].Person_aufnehmen();
                    iKundzahl++;
                    break;
                case 'f':
                    Mitglied[iKundzahl] = new Firma_Kunde();
                    Mitglied[iKundzahl].Person_aufnehmen();
                    iKundzahl++;
                    break;

            }
            iKundzahl++;
        }

        public void Mitgliederliste_ausgeben()
        {
            int i = 0;
            do
            {
                Thread.Sleep(200);
                i++;
                Console.WriteLine("Kunden Nr:{0}", i);
                i--;
                Thread.Sleep(200);
                Mitglied[1].Person_ausgeben();
                i++;
            }
            while (i != iKundzahl);
        }

        public void Automobil_Eingeben()
        {
            Console.WriteLine("\n\n\n - Zur AutomobilEingabe");
            Console.WriteLine("\n       <A>uto oder <L>kw");

            ConsoleKeyInfo taste;
            taste = Console.ReadKey(true);
            switch (taste.KeyChar)
            {
                case 'a':
                    Autoos[iAutozahl] = new Auto();
                    Autoos[iAutozahl].Auto_eingeben();
                    iAutozahl++;
                    break;
                case 'l':
                    Autoos[iAutozahl] = new Lkw();
                    Autoos[iAutozahl].Auto_eingeben();
                    iAutozahl++;
                    break;

            }
            iAutozahl++;
        }

        public void Automobile_ausgeben(int Anzahl)
        {
            for (int i = 0; i < Anzahl; i++)
            {
                Console.WriteLine("Auto Nr:{0}", i);
                Autoos[i].Autos_Ausgeben();
            }
            Console.ReadKey();
        }

        public void Auto_Buchen()
        {
            Console.WriteLine("------------------");
            Console.WriteLine("Buchung  ");
            Console.Write("------------------");
            Console.WriteLine("Alle Buchungen haben eine 30 Euro Grundgebuehr");
            Console.WriteLine("   **Eingabe**");

            Console.Write("Kunden Nummer:"); iKunde = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.Write("Auto Nummer  :"); iAuto = Convert.ToInt32(Console.ReadLine()) - 1;

            Mieten[iBuchzahl] = new buchung(Autoos[iAuto], Mitglied[iKunde], iAuto, iKunde);
            iBuchzahl++;
        }

        public void Buchung_Abrechnen()
        {
            int i = 0;
            Console.WriteLine("Buchung Nr?"); i = Convert.ToInt32(Console.ReadLine());
            Mieten[i].Buchung_abrechnen();
            Console.ReadKey();
        }

        public void Buchungen_Ausgeben(int lfdNr)
        {
            for (int i = 0; i < lfdNr; i++)
            {
                Console.WriteLine("Buchung Nr:", i);
                Mieten[i].Bugungen_Ausgeben();
            }

            Console.ReadKey(true);
        }
        public void Schubladen_schieber( char ch, string st1, string st2, string st3, string st4, string st5, string st6, string st7)
        {
            if (ch == 'k')
            {
                Mitglied[iKundzahl] = new Kunde();
                Mitglied[iKundzahl].Schubladen_oeffnerK(st1, st2, st3, st4, st5, st6);
                iKundzahl++;
            }

            if (ch == 'f')
            {
                Mitglied[iKundzahl] = new Firma_Kunde();
                Mitglied[iKundzahl].Schubladen_oeffnerK(st1, st2, st3, st4, st5, st6);
                iKundzahl++;
            }

            if (ch == 'a')
            {
                Autoos[iAutozahl] = new Auto();
                Autoos[iAutozahl].Schubladen_oeffnerA(st1, st2, st3, st4, st5, st6, st7);
                iAutozahl++;
            }

            if (ch == 'l')
            {
                Autoos[iAutozahl] = new Lkw();
                Autoos[iAutozahl].Schubladen_oeffnerA(st1, st2, st3, st4, st5, st6, st7);
                iAutozahl++;
            }

            if (ch == 'b')
            {
                iAuto = Convert.ToInt32(st1);
                iKunde = Convert.ToInt32(st2);
                Mieten[iBuchzahl] = new buchung(Autoos[iAuto], Mitglied[iKunde], iAuto, iKunde);
                iBuchzahl++;
            }
        }

                  // ein teil vom speicherer ist hier weil die verwaltung die arrays hat 
        public void Speicherer()
        {

            string Datei = @"c:\Peson/KundenDaten/TeeDaten.txt";
            StreamWriter swSpeii = new StreamWriter(Datei);

            int i = 0;
            char c = ' ';
            string s = " ";

            do
            {
                s = Autoos[i].Datt_gebA();
                c = Convert.ToChar(s);
                if (c=='a')
                {
                    swSpeii.Write("{0};", c);
                    s = Autoos[i].Datt_gebA();
                    swSpeii.Write("{0};", s);
                    s = Autoos[i].Datt_gebA();
                    swSpeii.Write("{0};", s);
                    s = Autoos[i].Datt_gebA();
                    swSpeii.Write("{0};", s);
                    s = Autoos[i].Datt_gebA();
                    swSpeii.Write("{0};", s);
                    s = Autoos[i].Datt_gebA();
                    swSpeii.Write("{0};", s);
                    s = Autoos[i].Datt_gebA();
                    swSpeii.Write("{0};", s);
                    s = Autoos[i].Datt_gebA();
                    swSpeii.WriteLine("{0};", s);
                }
                else
                {
                    swSpeii.Write("l;");
                    s = Autoos[i].Datt_gebA();
                    swSpeii.Write("{0};", s);
                    s = Autoos[i].Datt_gebA();
                    swSpeii.Write("{0};", s);
                    s = Autoos[i].Datt_gebA();
                    swSpeii.Write("{0};", s);
                    s = Autoos[i].Datt_gebA();
                    swSpeii.Write("{0};", s);
                    s = Autoos[i].Datt_gebA();
                    swSpeii.WriteLine("{0};", s);
                }
                i++;
            }
            while (iAutozahl+1 != i);
            i = 0;
            do
            {
                s = Mitglied[i].Datt_gebK();
                c = Convert.ToChar(s);
                if ( c=='k')
                {
                    swSpeii.Write("{0};", c);
                    s = Mitglied[i].Datt_gebK();
                    swSpeii.Write("{0};", s);
                    s = Mitglied[i].Datt_gebK();
                    swSpeii.Write("{0};", s);
                    s = Mitglied[i].Datt_gebK();
                    swSpeii.Write("{0};", s);
                    s = Mitglied[i].Datt_gebK();
                    swSpeii.Write("{0};", s);
                    s = Mitglied[i].Datt_gebK();
                    swSpeii.Write("{0};", s);
                    s = Mitglied[i].Datt_gebK();
                    swSpeii.WriteLine("{0};", s);
                }
                else
                {
                    swSpeii.Write("f;");
                    s = Mitglied[i].Datt_gebK();
                    swSpeii.Write("{0};", s);
                    s = Mitglied[i].Datt_gebK();
                    swSpeii.Write("{0};", s);
                    s = Mitglied[i].Datt_gebK();
                    swSpeii.Write("{0};", s);
                    s = Mitglied[i].Datt_gebK();
                    swSpeii.Write("{0};", s);
                    s = Mitglied[i].Datt_gebK();
                    swSpeii.WriteLine("{0};", s);
                }
                i++;
            }
            while (iKundzahl+1 != i);
            i = 0;
            do
            {
                swSpeii.Write("b;");
                s = Mieten[i].Datt_gebB();
                swSpeii.Write("{0};", s);
                s = Mieten[i].Datt_gebB();
                swSpeii.WriteLine("{0};", s);
                i++;
            }
            while (iBuchzahl+1 != i);

            Console.WriteLine("Speichern erfolgreich. knopf drücken um fortzufahren.");
            Console.ReadKey();

        }
    }
}
