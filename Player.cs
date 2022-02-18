using System;

namespace Rpg
{
    public class Player
    {
        public string name;
        public string proffesion;
        public int healt = 10;
        
        public Player(string name, string proffesion)
        {
            this.name = name;
            this.proffesion = name;
        }
        public override string ToString()
        {
            return this.name;
        }
    }
} 