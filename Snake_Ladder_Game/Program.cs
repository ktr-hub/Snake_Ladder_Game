using System;

namespace Snake_Ladder_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Player noob1 = new Player();

            Console.WriteLine("Player is at position : " + noob1.getPosition());
        }
    }
}
