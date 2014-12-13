using System;
using System.Collections.Generic;
using System.Text;

namespace Kret
{
    public class Player
    {
        public string Name
        {
            set;
            get;
        }

        public int Score
        {
            set;
            get;
        }

        public int Lives
        {
            set;
            get;
        }

        public Player(string name, int score) 
        {
            Name = name;
            Score = score;
        }

        public Player(string name, int score, int lives)
        {
            Name = name;
            Score = score;
            Lives = lives;
        }
    }
}
