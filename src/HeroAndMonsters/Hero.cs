using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroAndMonsters
{
    public class Hero : GameEntity, IFight
    {

        public Hero(string name, int power, int health, int experience) : base(name, power, health, experience)
       {
           /* Name = name;
            Power = power;
            Health = health;
            Experience = experience;*/
        }

        public void Fight(GameEntity enemy)
        {
            enemy.Health -= this.Power;
            if (enemy.Health > 0)
            {
                this.Health -= enemy.Power;
            }

            if (enemy.IsDefeated())
            {
                this.Experience += 10;
                this.Power += 5;
                this.Health += 10;
            }


        }

    }
}
