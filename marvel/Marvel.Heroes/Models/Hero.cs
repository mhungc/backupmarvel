using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Marvel.Heroes.Models
{
    public class Hero
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public PowerLevel PowerLevel { get; set; }
    }
}
