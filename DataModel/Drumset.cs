using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataModel
{
    public class Drumset
    {
        public string Name { get; set; }

        public HiHat HiHat { get; set; }

        public List<Tom> Toms { get; set; }

        public List<Cymbal> Cymbals { get; set; }
    }
}
