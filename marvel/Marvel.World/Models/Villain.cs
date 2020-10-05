using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Marvel.World.Models
{
    public class Villain
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public PowerLevel PowerLevel { get; set; }
    }
}
