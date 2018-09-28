using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnhancedMap.Core
{
    public class SpawnDefinition
    {
      
        public string NPCCount { get; set; }
        public string HomeRange { get; set; }
        public bool BringToHome { get; set; }
        public string MinTime { get; set; }
        public string MaxTime { get; set; }
        public string Team { get; set; }
        public string SpawnerName { get; set; }
        public List<string> Mobiles { get; set; }
        public string X { get; set; }
        public string Y { get; set; }
        public string MapId { get; set; }
        public bool UniqueSpawn { get; internal set; }

        public SpawnDefinition() { Mobiles = new List<string>(); }
    }
}
