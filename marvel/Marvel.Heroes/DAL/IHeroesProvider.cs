using Marvel.Heroes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Marvel.Heroes.DAL
{
    public interface IHeroesProvider
    {
        Task<Hero> GetAsync(string id);
        Task<List<Hero>> GetAsync();
    }
}
