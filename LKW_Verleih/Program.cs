using System;
using System.Threading;
namespace LKW_Verleih
{
    class Program
    {
                               //***GESCHRIEBEN VON _KaanKuzey Corp_***//

        static void Main(string[] args)  // hier ist der startpunkt des pgrogrammes festgelegt
        {
            Console.BackgroundColor = ConsoleColor.White;   // änderung der hintergrund Farbe
            Console.ForegroundColor = ConsoleColor.Black;   // änderung der Schriftfarbe
            Console.Clear();            // Das gesamte Consolenfenster wird mit leertasten überschrieben

            Menue Menno = new Menue();    // ein neues objekt von Menue wird erzeugt um dessen funktion nutzbar zu machen
            verwaltung AutoVerleih = new verwaltung(); // dies ebenso für verwaltung
            lader ladd = new lader();                  // und auch lader
            int i = 0, u = 0, z = 0;     // <-- zählervariablen die später als parameter übergeben werden
            ConsoleKeyInfo taste;     // Consolekeyinfo variable wird erzeugt

            do  // oberseite der schleife
            {
                Menno.Menue_anzeigen();  // die einzige funktion von Menue wird aufgerufen
                taste = Console.ReadKey(true); // taste wir ein selbst eingegebenes zeichen zugewiesen

                switch (taste.KeyChar)  // eine kreuzung wo man einen weg auf einmal betreten darf wo Consolekeyinfo abgefragt wird
                {
                    case '1':  //die bedingung um diesen weg zu begehen
                        Console.Clear();
                        AutoVerleih.Mitglied_aufnehmen();
                        i++;
                        break;
                    case '2':
                        Console.Clear();
                        AutoVerleih.Mitgliederliste_ausgeben();
                        Console.ReadKey();
                        break;
                    case '3':
                        Console.Clear();
                        AutoVerleih.Automobil_Eingeben();
                        u++;
                        break;
                    case '4':
                        Console.Clear();
                        AutoVerleih.Automobile_ausgeben(u);
                        break;
                    case '5':
                        Console.Clear();
                        AutoVerleih.Auto_Buchen();
                        z++;
                        break;
                    case '6':
                        Console.Clear();
                        AutoVerleih.Buchung_Abrechnen();
                        break;
                    case '7':
                        Console.Clear();
                        AutoVerleih.Buchungen_Ausgeben(z);
                        break;
                    case '8':
                        Console.Clear();
                        ladd.lesar_gebar();
                        break;
                    case '9':
                        AutoVerleih.Speicherer();
                        break;

                }
            }
            while (taste.Key != ConsoleKey.Escape);  // unterseite__ die schleife öffnet sich wenn taste "Esc" zugewiesen wird

            Console.ReadKey(); // tastenabfrage
        }
    }
}
