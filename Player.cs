using System;

namespace Rpg
{
    class Player
    {
        public string name;
        public int healt = 10;
        
        public Player(string name)
        {
            this.name = name;
        }
        public override string ToString()
        {
            return this.name;
        }
    }
} 