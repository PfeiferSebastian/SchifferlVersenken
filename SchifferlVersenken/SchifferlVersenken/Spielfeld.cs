using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchifferlVersenken
{
    class Spielfeld
    {
        const int seasize = 10;
        string[,] sea = new string[seasize, seasize];
        

        //Methode erstellt den See
        public void clearsea()
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
        public void drawsea()
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
        public void setshipsonSea(string[,] sea)
        {
            this.sea = sea;
        }

        //Methode übergibt Koordinaten der Angriffe an den Array
        public void setAttacksOnShips(string[,] attack)
        {
            this.sea = attack;
        }
    }
}
