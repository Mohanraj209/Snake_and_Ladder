using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_and_Ladder
{
    internal class Simulator
    {
        // Game related attributes declared here
        int Position = 0;
        public void Starting_Point()
        {
            Console.WriteLine("Initial Position: " + Position);
        }
        public void Dice_Roll()
        {
            Random random = new Random();
            int Roll = random.Next(1, 7);
            Console.WriteLine("Dice Number: " + Roll);
        }

    }

}
