using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroAndMonsters
{
    public class Monster : GameEntity, IFight
    {
        public Monster(string name, int power, int health, int experience) : base(name, power, health, experience)
        {

        }

        public void Fight(GameEntity opponent)
        {
            opponent.Health -= this.Power;
            if (opponent.Health > 0)
            {
                this.Health -= opponent.Power;
            }
        }
    }
}
