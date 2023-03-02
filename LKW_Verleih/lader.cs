using System;
using System.Text;
using System.IO;
using System.Threading;
using System.Collections.Generic;

namespace LKW_Verleih
{
    class lader
    {
        public void lesar_gebar()
        {
            verwaltung vee = new verwaltung();    

            string sDetName = @"c:\peson/KundenDaten/TeeDaten.txt";
            StreamReader srDatta = new StreamReader(sDetName);

            string s = " ";                        
            int i = 0, j = 0;                   // zählervariablen
            while(srDatta.Peek() != -1)         // Es wird nachgeschaut wie viele datensätze es gibt
            {
                srDatta.ReadLine();
                i++;
            }
            do
            {
                FileInfo fiFILLO = new FileInfo(@"c:\peson/KundenDaten/TeeDaten.txt");

                s = Convert.ToString(i);     // für die ladeprozess anzeige 

                int raah = 0, va=0 ;
                string st1="Fehler", st2="Fehler", st3="Fehler", st4="Fehler", st5="Fehler", st6="Fehler", st7="Fehler"; //strings mit platzhaltern
                char beh = 'a';

                st1 = lupe(raah,va);   // der char am anfang wird eingelesen
                raah++;
                beh = Convert.ToChar(st1);

                if (beh == 'b')  // je nachdem was für ein datensatz in dieser zeile ist werden auch die strings "gefüllt"
                {

                    st1 = lupe(raah, va);
                    raah++;
                    st2 = lupe(raah,va);
                    
                }
                if (beh == 'l')
                {
                    st1 = lupe(raah,va);
                    raah++;
                    st2 = lupe(raah,va);
                    raah++;
                    st3 = lupe(raah,va);
                    raah++;
                    st4 = lupe(raah,va);
                    raah++;
                    st5 = lupe(raah,va);
                    raah++;
                    st6 = lupe(raah,va);
                    raah++;
                    st7 = lupe(raah,va);
                }
                else
                {
                    st1 = lupe(raah,va);
                    raah++;
                    st2 = lupe(raah,va);
                    raah++;
                    st3 = lupe(raah,va);
                    raah++;
                    st4 = lupe(raah,va);
                    raah++;
                    st5 = lupe(raah,va);
                    raah++;
                    if (beh != 'f')
                    {
                    Console.SetCursorPosition(10, 10);  //das hier ist nicht so wichtig
                    Console.Write("weeeeee");
                    Thread.Sleep(30);
                    Console.SetCursorPosition(10, 10);
                    Console.Write("       ");
                    }
                    else
                    {
                        st6 = lupe(raah,va);
                        raah++;
                    }
                }
                vee.Schubladen_schieber(beh, st1, st2, st3, st4, st5, st6, st7); // die daten werden and die Verwaltung übergeben

                i--;   // die zählervariablen werden gezählt
                j++;
                va++;

                Console.SetCursorPosition(5, 5);                    // die ladeprozess Anzeige
                Console.Write("{0} von {1} geladen",j ,s );
                Thread.Sleep(400);
            }
            while (i!=0); // die schleife schliesst sich wenn alle gezählten datensätze eingelesen wurden
        }

        private string lupe(int za,int va)
        {
            string sDetName = @"c:\peson/KundenDaten/TeeDaten.txt", ausg = " ";
            string sdasZeile;
            bool eh = false;

            StringBuilder sbName = new StringBuilder(); // es ist nur ein stringbuilder gebraucht weil daten einzeln übertragen werden
            StreamReader srData = new StreamReader(sDetName);
            
            int i = 0, j = 0;
            while (srData.Peek() != -1)
            {
                do    // diese do while schleife ist hier um ein bestimmte anzahl von zeilen zu überspringen
                {
                    sdasZeile = (srData.ReadLine());
                    va--;
                }
                while ( va>0 );
                int av = 0;
                do
                {
                    av = va;
                    sdasZeile = (srData.ReadLine());
                    do
                    {
                        if (sdasZeile[i] == ';') za++;
                        i++;

                        if (za == 1) eh = true;
                    }
                    while (za != 1);

                    if (eh == true)
                    {
                        do
                        {
                            sbName.Append(sdasZeile[i]); i++;
                        }
                        while (sdasZeile[i] != ';');
                        za++;
                    }
                    eh = false;
                    ausg = Convert.ToString(sbName);

                    j++;
                    va ++;

                }
                while (av + 1 != va);
            }
            srData.Close();
            return ausg;
        }
    }
}
