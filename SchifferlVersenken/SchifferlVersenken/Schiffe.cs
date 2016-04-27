using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchifferlVersenken
{
    // public enum Schiffklassen
    //{ Traeger, Schlachtschiff, Kreuzer, Uboot, Zerstoerer };

    static class Schiffe
    {

        static int ship1 = 3, ship2 = 4, ship3 = 5;
        static string[,] ship = null;

        //Schiffplatzierung auf dem Wasser
        static public void placeship()
        {
            Spielfeld.setshipsonSea(ship);

            ship[1, 5] = Convert.ToString(ship1);
            ship[2, 5] = Convert.ToString(ship1);
            ship[3, 5] = Convert.ToString(ship1);

            ship[6, 3] = Convert.ToString(ship2);
            ship[6, 4] = Convert.ToString(ship2);
            ship[6, 5] = Convert.ToString(ship2);
            ship[6, 6] = Convert.ToString(ship2);
            ship[6, 7] = Convert.ToString(ship2);
            //sea[1, 5] = Convert.ToString(ship1);
            //sea[2, 5] = Convert.ToString(ship1);
            //sea[3, 5] = Convert.ToString(ship1);

            //sea[6, 3] = Convert.ToString(ship2);
            //sea[6, 4] = Convert.ToString(ship2);
            //sea[6, 5] = Convert.ToString(ship2);
            //sea[6, 6] = Convert.ToString(ship2);
            //sea[6, 7] = Convert.ToString(ship2);
        }
    }
}
