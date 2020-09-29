using System;

namespace Snake_Ladder_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Player []noob = new Player[2];
            noob[0] = new Player();
            noob[1] = new Player();

            int [] position = new int[2];
            position[0] = noob[0].getPosition();
            position[1] = noob[1].getPosition();

            int diceSwitch=0,option=1;
            int [] numberOfTimesDiceRolled = new int[2];
            
            Console.WriteLine("Player 1 is at position : " + position[0]);
            Console.WriteLine("Player 2 is at position : " + position[1]);

            while (position[0] != 100 && position[1]!=100)
            {
                if (option != 1 && diceSwitch == 0)
                {
                    diceSwitch = 1;
                }
                else if (option != 1 && diceSwitch == 1)
                {
                    diceSwitch = 0;
                }

                int ValueOnDie = noob[diceSwitch].rollDie();

                Console.WriteLine("\nPlayer "+ (diceSwitch+1) +" Dice showing : " + ValueOnDie);

                option = noob[diceSwitch].setOption();

                position[diceSwitch] = noob[diceSwitch].getPosition();

                Console.WriteLine("Player "+(diceSwitch+1)+ " is at position : " + position[diceSwitch]);
                numberOfTimesDiceRolled[diceSwitch] = numberOfTimesDiceRolled[diceSwitch] + 1;

            }

            Console.WriteLine("\nPlayer " + (diceSwitch+1) +" rolled the dice " + numberOfTimesDiceRolled[diceSwitch] + " times to win the game.");

        }
    }
}
