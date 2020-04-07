using Spawn.Core.MapObjects;
using System.ComponentModel;
using System.IO;


namespace Spawn.Core
{
    public class SpawnWriter
    {
        public SpawnWriter() { }

        public SpawnWriter(BindingList<SpawnObject> spawns)
        {
            Spawns = spawns;
        }

        public BindingList<SpawnObject> Spawns { get; private set; }

        public void Save(string fileName)
        {
            using (var writer = new StreamWriter(fileName))
            {
                foreach(var spawn in Spawns)
                {
                    writer.WriteLine(spawn.ToText());
                }
            }    
        }
    }
}
