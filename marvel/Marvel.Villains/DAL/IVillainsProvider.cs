using Marvel.Villains.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Marvel.Villains.DAL
{
    public interface IVillainsProvider
    {
        Task<Villain> GetAsync(string id);
        Task<List<Villain>> GetAsync();
    }
}
