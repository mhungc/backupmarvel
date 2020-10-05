using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Marvel.World.Models
{
    public class FightWorld
    {
        public Hero Hero { get; private set; }
        public Villain Villain { get; private set; }

        public FightWorld(Hero hero, Villain villain)
        {
            Hero = hero;
            Villain = villain;
        }
    }
}
