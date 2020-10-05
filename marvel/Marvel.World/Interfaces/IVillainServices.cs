using Marvel.World.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Marvel.World.Interfaces
{
    public interface IVillainsServices
    {
        Task<Villain> GetAsync(string id);
        Task<IEnumerable<Villain>> GetAsync();
    }
}
