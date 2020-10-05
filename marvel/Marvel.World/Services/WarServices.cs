
using Marvel.World.Interfaces;
using Marvel.World.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Marvel.World.DAL
{
    public class WarServices : IWarServices
    {
        private List<FightWorld> _fightWorldRepository = new List<FightWorld>();
        IHeroesServices _heroesServices;
        IVillainsServices _villainsServices;

        public WarServices(IHeroesServices heroesServices, IVillainsServices villainsServices)
        {
            _heroesServices = heroesServices;
            _villainsServices = villainsServices;
        }

        async Task<IEnumerable<War>> IWarServices.GetAsync()
        {
            //Asume that the lenght of heroes nad Villains are the same.
            var heroes = (await _heroesServices.GetAsync()).ToArray();

            var villains = (await _villainsServices.GetAsync()).ToArray();

            var wars = new List<War>();

            for (int i = 0; i < 100; i++)
            {
                var war = new War(heroes[i], villains[i]);
                war.Fight();
                wars.Add(war);
            }

            return wars;
        }
    }
}
