using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchifferlVersenken
{
    static class GameLogic
    {
        //Arraycodes:

        //  Spielfeld:
        //   Null = Feld leer
        //   ~    = Wasser
        //   2-5  = Schiff
        //   O = Fehlschuss
        //   X = Treffer

        // Sieg bei Array-Summe von 34

        
        static string[,] attackcoordinates = null;


        static void setNames()
        {

            //Console.WriteLine("1. Spieler: ");
            //Spieler.P1Name = Convert.ToString(Console.ReadLine());
            //Console.WriteLine("2. Spieler: ");
            //Spieler.P2Name = Convert.ToString(Console.ReadLine());
        }


        static void attack()
        {
            //int cx, cy;

            //Console.WriteLine("coordinate x:");
            //cx = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("coordinate y");
            //cy = Convert.ToInt32(Console.ReadLine());

            //attackcoordinates[cx, cy] = "X";

            //Spieler.setAttacksOnShips(attackcoordinates);
        }

        static void Spiel()
        {
            GameLogic.setNames();
            Spielfeld.clearsea();
            Schiffe.placeship();
            GameLogic.attack();
            Spielfeld.drawsea();
            Console.ReadLine();
        }

        

        #region Methoden

        ////Für Methoden im Spiel
        //public void SpielfeldInitialisieren_P1(string[,,] a)
        //{

        //}

        //public void SpielfeldInitialisieren_P2(string[,,] a)
        //{

        //}

        //public void Platzierung_p1()
        //{ }

        //public void Platzierung_p2()
        //{ }

        //public void Positionscheck()
        //{ }

        //public void Spielzug(int spieler)
        //{ }

        //public void Siegesbedingung()
        //{ }

        #endregion

    }
}
