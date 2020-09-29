using System;

namespace Snake_Ladder_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Player noob1 = new Player();
            int position = 0; //initialization
            Console.WriteLine("Player is at position : " + noob1.getPosition());

            while (position != 100)
            {
                int valueOnDie = noob1.rollDie();

                Console.WriteLine("\nDice showing : " + valueOnDie);

                noob1.setOption();

                position = noob1.getPosition();

                Console.WriteLine("Player is at position : " + position);
            }

        }
    }
}
