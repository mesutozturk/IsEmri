using System.Collections.Generic;
using System.Linq;

namespace IsEmri.Business.Models
{
    public class RaporAggregator
    {
        public int Kod { get; set; }
        public List<Durus> Duruslar { get; set; }

        public int ToplamSure => Duruslar.Sum(x => x.Sure);
    }
}
