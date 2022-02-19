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
        int Position_1 = 0;
        int Position_2 = 0;
        int Count_1 = 0;
        int Count_2 = 0;
        public void Starting_Point()
        {
            Console.WriteLine("Initial Position of player1: " + Position_1);
            Console.WriteLine("Initial Position of player2: " + Position_2);
        }
        public void Dice_Roll()
        {
            Random random1 = new Random();
            int Roll_1 = random1.Next(1, 7);
            Console.WriteLine("\n Dice Number 1: " + Roll_1);
            Position_1 += Roll_1;
            Count_1++;
            Random random2 = new Random();
            int Roll_2 = random2.Next(1, 7);
            Console.WriteLine(" Dice Number 2: " + Roll_2);
            Position_2 += Roll_2;
            Count_2++;
            Option(Roll_1, Roll_2);
            Endpoint1();
            Endpoint2();
            Starting_Point();
        }

        public void Option(int Roll_1, int Roll_2)
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
                    Console.WriteLine("\n Thought you were going to win aren't you! Snake bite");
                    Console.WriteLine("Position of player1 lowered to " + Roll_1);
                    Console.WriteLine("Position of player2 lowered to " + Roll_2);
                    Position_1 -= Roll_1;
                    Position_2 -= Roll_2;
                    break;
                case 2:
                    // when option is ladder
                    Console.WriteLine("You are not going much further! Climb Ladder");
                    Console.WriteLine("Position of player1 highered to " + Roll_1);
                    Console.WriteLine("Position of player2 highered to " + Roll_2);
                    Position_1 += Roll_1;
                    Position_1 += Roll_2;
                    break;
                default:
                    Console.WriteLine("Error!");
                    break;
            }

        }
        // Checks if position reaches 100
        public void Endpoint1()
        {
            if (Position_1 < 0)
                Position_1 = 0;
            else if (Position_1 >= 100)
                Position_1 = 100;
        }
        public void Endpoint2()
         {
            if (Position_2< 0)
                Position_2 = 0;
            else if (Position_2 >= 100)
                Position_2 = 100;
        }

    // This will roll die untill player wins
    public void Win_position1()
        {
            while (Position_1 < 100)
                Dice_Roll();
            Console.WriteLine("\n Congratulations!! player1 Won");
            Console.WriteLine("Number of times die rolled is :: " + Count_1);
        }

        public void Win_position2()
        {
            while (Position_2 < 100)
                Dice_Roll();
            Console.WriteLine("\n Congratulations!! player2 Won");
            Console.WriteLine("Number of times die rolled is :: " + Count_2);
        }

    }

}




