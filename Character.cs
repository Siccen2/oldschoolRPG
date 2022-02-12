using System;

namespace Rpg
{
    class Character
    {
        public string name {get;}
        
        public Character(string name)
        {
            this.name = name;    
        }
        public void Healt()
        {
            int healt = 10;
        }
        public override string ToString()
        {
            return this.name;
        }
    }
} 