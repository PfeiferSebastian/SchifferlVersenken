using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchifferlVersenken
{
    internal class Spielfeld
    {
        //Arrays für die Spieler

            //Arraycodes:

            // Version 2:
            //  Platzierung:
            //   Null = Feld verfügbar
            //   0    = Feld gesperrt
            //   1-5  = Schiff

            //  Spielfeld:
            //   Null = Feld leer
            //   0    = Wasser
            //   1-5  = Schiff
            //   2-10 = Treffer
            
            // Sieg bei Array-Summe von 34
            
        //Spieler 1
        
        static int [,,] P1Array = new int [10, 10, 2];

        //Spieler 2

        static int [,,] P2Array = new int[10, 10, 2];

    }
}
