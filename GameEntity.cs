using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroAndMonsters
{
    
    public class GameEntity
    {
        public string Name;
        public int Power;
        public int Health;
        public int Experience;

       public GameEntity(string Name,int Power, int Health, int Experience)
        { 
            this.Name = Name;
            this.Power = Power; 
            this.Health = Health;
            this.Experience = Experience;
        }

        GameEntity()
        { 

        }
        
    }
}
