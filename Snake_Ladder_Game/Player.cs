﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Snake_Ladder_Game
{
    class Player
    {
        public int position;

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

    }
}