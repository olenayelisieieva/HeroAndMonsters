using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroAndMonsters
{
    
    public class GameEntity
    {
        public string Name { get; set; }
        public int Power { get; set; }
        public int Health { get; set; }
        public int Experience { get; set; }

        public GameEntity(string name,int power, int health, int experience)
        { 
            Name = name;
            Power = power; 
            Health = health;
            Experience = experience;
        }

        public bool IsDefeated()
        {
            return Health <= 0 || Power <= 0;
        }

    }
}
