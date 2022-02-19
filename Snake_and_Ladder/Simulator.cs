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
        int Count = 0;
        public void Starting_Point()
        {
            Console.WriteLine("Initial Position: " + Position);
        }
        public void Dice_Roll()
        {
            Random random = new Random();
            int Roll = random.Next(1, 7);
            Console.WriteLine("Dice Number: " + Roll);
            Position += Roll;
            Count++;
            Option(Roll);
            Endpoint();
            Starting_Point();
        }

        public void Option(int Roll)
        {
            Random random = new Random();
            int option = random.Next(0, 3);
            switch (option)
            {
                case 0:
                    // when option is no play! 
                    Console.WriteLine("No Play");
                    break;
                case 1:
                    // when option is snake
                    Console.WriteLine("Thought you were going to win aren't you! Snake bite");
                    Console.WriteLine("Position lowered to " + Roll);
                    Position -= Roll;
                    break;
                case 2:
                    // when option is ladder
                    Console.WriteLine("You are not going much further! Climb Ladder");
                    Console.WriteLine("Position highered to " + Roll);
                    Position += Roll;
                    break;
                default:
                    Console.WriteLine("Error!");
                    break;
            }

        }
        // Checks if position reaches 100
        public void Endpoint()
        {
            if (Position < 0)
                Position = 0;
            else if (Position >= 100)
                Position = 100;
        }

        // This will roll die untill player wins
        public void Win_position()
        {
            while (Position < 100)
                Dice_Roll();
            Console.WriteLine("Congratulations!! you Won");
            Console.WriteLine("Number of times die rolled is :: " + Count);
        }

       
    }
}




