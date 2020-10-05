using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Marvel.World.Models
{
    public class War
    {
        private Hero _hero;
        public Hero Hero { get => _hero; private set => _hero = value; }

        private Villain _villain;
        public Villain Villain { get => _villain; private set => _villain = value; }

        private FightResult _fightResult;
        public FightResult FightResult { get => _fightResult; private set => _fightResult = value; }

        private string _showResult;
        public string ShowResult { get => _showResult; private set => _showResult = value; }

        public War(Hero hero, Villain villain)
        {
            _hero = hero;
            _villain = villain;
        }

        public void Fight()
        {
            _fightResult = (_hero.PowerLevel > _villain.PowerLevel) ? FightResult.Win : FightResult.Lose;
            _showResult = _fightResult.ToString();
        }
    }
}
