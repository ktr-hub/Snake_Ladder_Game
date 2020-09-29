using System;
using System.Collections.Generic;
using System.Text;

namespace Snake_Ladder_Game
{
    class Player
    {
        public int position;
        public int valueOnDie;
        public const int NO_PLAY = 0;
        public const int LADDER = 1;
        public const int SNAKE = 2;

        public Player()
        {
            position = 0;
        }

        public void setPostion(int position)
        {
            this.position = position;
        }

        public int getPosition()
        {
            return this.position;
        }

        public int rollDie()
        {
            Random dice = new Random();
            this.valueOnDie = dice.Next(1, 7);
            return valueOnDie;
        }

        public void setOption()
        {
            Random random = new Random();
            int option = random.Next(0, 3);
            switch (option)
            {
                case SNAKE:
                    Console.WriteLine("Snake encountered ");
                    this.position = this.position - valueOnDie;
                    
                    if (this.position < 0)
                    {
                        this.position = 0;
                    }

                    break;
                case LADDER:
                    Console.WriteLine("Ladder encountered ");
                    this.position = this.position + valueOnDie;
                    break;
                case NO_PLAY:
                    Console.WriteLine("No play encountered");
                    break;
            }
        }

    }
}
