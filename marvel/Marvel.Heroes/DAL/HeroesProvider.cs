using Marvel.Heroes.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Marvel.Heroes.DAL
{
    public class HeroesProvider : IHeroesProvider
    {
        private List<Hero> heroesRepository = new List<Hero>();

        public HeroesProvider()
        {
            var random = new Random();

            for (int i = 0; i < 100; i++)
            {
                heroesRepository.Add(new Hero()
                {
                    Id = i.ToString(),
                    Name = "Spider Man " + i,
                    PowerLevel = (PowerLevel)random.Next(3)
                });
            }
        }

        public Task<Hero> GetAsync(string id)
        {
            var hero = heroesRepository.FirstOrDefault(h => h.Id == id);
            return Task.FromResult(hero);
        }

        public Task<List<Hero>> GetAsync()
        {
            var heroes = heroesRepository.ToList();
            return Task.FromResult(heroes);
        }
    }
}
