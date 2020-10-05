﻿using Marvel.World.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Marvel.World.Interfaces
{
    public interface IHeroesServices
    {
        Task<Hero> GetAsync(string id);
        Task<IEnumerable<Hero>> GetAsync();
    }
}
