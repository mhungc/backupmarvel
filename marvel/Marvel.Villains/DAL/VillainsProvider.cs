using Marvel.Villains.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Marvel.Villains.DAL
{
    public class VillainsProvider : IVillainsProvider
    {
        private List<Villain> _villainsRepository = new List<Villain>();

        public VillainsProvider()
        {
            var random = new Random();

            for (int i = 0; i < 100; i++)
            {
                _villainsRepository.Add(new Villain()
                {
                    Id = i.ToString(),
                    Name = "Dr. Octopus " + i,
                    PowerLevel = (PowerLevel)random.Next(3)
                });
            }
        }

        public Task<Villain> GetAsync(string id)
        {
            var Villains = _villainsRepository.FirstOrDefault(h => h.Id == id);
            return Task.FromResult(Villains);
        }

        public Task<List<Villain>> GetAsync()
        {
            var heroes = _villainsRepository.ToList();
            return Task.FromResult(heroes);
        }
    }
}
