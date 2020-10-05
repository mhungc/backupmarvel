using Marvel.World.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Marvel.World.DAL
{
    public interface IWarServices
    {
        Task<IEnumerable<War>> GetAsync();
    }
}
