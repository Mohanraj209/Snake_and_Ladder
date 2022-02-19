using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_and_Ladder

{
     class Program
    {
        public static void Main()
        {
            Console.WriteLine("--------------Snake and Ladder Simulator-------------");
            Simulator player1 = new Simulator();
            player1.Starting_Point();
            player1.Dice_Roll();
            player1.Endpoint1();
            player1.Endpoint2();
            player1.Win_position1();
            player1.Win_position2();
            Console.ReadKey();
        }
    }
}
