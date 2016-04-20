using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchifferlVersenken
{
    internal class BL
    {
        #region Felder & Eigenschaften
        //Spieler
        public string P1Name { get; set; }
        public string P2Name { get; set; }
        public int AktuellerSpieler { get; set; }

        //Schiffe
        public int Traeger { get; set; }
        public int Schlachtschiff { get; set; }
        public int Kreuzer { get; set; }
        public int Zerstoerer { get; set; }
        #endregion

        #region Methoden

        //Für Methoden im Spiel

        public void platzierung_p1()
        { }

        public void platzierung_p2()
        { }

        public void positionscheck()
        { }

        public void spielzug(int spieler)
        { }

        public void siegesbedingung()
        { }

        #endregion




    }
}
