using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchifferlVersenken
{
    static class Spielfeld
    {
        static int seasize = 10;
        static string[,] sea = new string[seasize, seasize];


        //Methode erstellt den See
        static public void clearsea()
        {
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    sea[x, y] = "~";
                }
            }
        }

        //Mehtode zeichnet den See auf der Console
        static public void drawsea()
        {
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    Console.Write(" ");
                    Console.Write(sea[x, y]);
                }
                Console.WriteLine(" ");
            }
        }

        //Methode um die Schiffe auf dem Sea zu positionieren über Parameter
        static public void setshipsonSea(string[,] sea)
        {
            Speilfeld.sea = sea;
        }

        //Methode übergibt Koordinaten der Angriffe an den Array
        static public void setAttacksOnShips(string[,] attack)
        {
            this.sea = attack;
        }
    }
}
