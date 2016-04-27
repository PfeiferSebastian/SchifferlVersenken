using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchifferlVersenken
{
    public class GameLogic
    {
        //Arraycodes:

        //  Spielfeld:
        //   Null = Feld leer
        //   ~    = Wasser
        //   2-5  = Schiff
        //   O = Fehlschuss
        //   X = Treffer

        // Sieg bei Array-Summe von 34

        Spielfeld sp = new Spielfeld();
        string[,] attackcoordinates = null;


        public void setNames()
        {
            Spieler sp = new Spieler();

            Console.WriteLine("1. Spieler: ");
            sp.P1Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("2. Spieler: ");
            sp.P2Name = Convert.ToString(Console.ReadLine());
        }

        
        public void attack()
        {
            int cx, cy;

            Console.WriteLine("coordinate x:");
            cx = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("coordinate y");
            cy = Convert.ToInt32(Console.ReadLine());

            attackcoordinates[cx, cy] = "X";

            sp.setAttacksOnShips(attackcoordinates);
        }

        public static void Spiel()
        {
            GameLogic gl = new GameLogic();
            Spielfeld sp = new Spielfeld();
            Schiffe sf = new Schiffe();

            gl.setNames();
            sp.clearsea();
            sf.placeship();
            gl.attack();
            sp.drawsea();
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
