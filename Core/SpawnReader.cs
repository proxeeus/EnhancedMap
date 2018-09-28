using EnhancedMap.Core.MapObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnhancedMap.Core
{
    public class SpawnReader
    {
        public string MapFileName { get; set; }

        public BindingList<SpawnObject> LoadSpawns()
        {
            var spawnObjects = new BindingList<SpawnObject>();

            using (var streamReader = new StreamReader(MapFileName))
            {
                var line = string.Empty;
                while ((line = streamReader.ReadLine()) != null)
                {
                    if (line.StartsWith("//")) continue;

                    if (line.StartsWith("-")) continue;

                    var indexOf = line.IndexOf(':');
                    var mobIndexOf = line.IndexOf("[");
                    var mobLastIndexOf = line.IndexOf("]");
                    if (indexOf == -1)  continue;

                    var spawnIndexOf = line.IndexOf('+');
                    if (spawnIndexOf == -1) continue;

                    var spawnDef = new SpawnDefinition();

                    var sub = line.Substring(++indexOf).Trim();
                    var spawnName = line.Substring(++spawnIndexOf, mobIndexOf - spawnIndexOf);
                    // Add split [] for mobiles here?
                    var mobs = line.Substring(++mobIndexOf, mobLastIndexOf - mobIndexOf);
                    var split = sub.Split(' ');
                    var mobSplit = mobs.Split(',');

                    var mobsList = new List<string>();
                    foreach (var mob in mobSplit)
                        mobsList.Add(mob.Trim());
                    spawnDef.Mobiles = mobsList;

                    if (split.Length < 3)
                        continue;

                    spawnDef.X = split[0];
                    spawnDef.Y = split[1];
                    spawnDef.MapId = split[2];
                    spawnDef.NPCCount = split[3];
                    spawnDef.HomeRange = split[4];
                    spawnDef.BringToHome = Convert.ToBoolean(split[5]);
                    spawnDef.MinTime = split[6];
                    spawnDef.MaxTime = split[7];
                    spawnDef.Team = split[8];
                    spawnDef.SpawnerName = spawnName.Trim();
                    // No use for Description right now

                    var spawnObject = new SpawnObject(Global.PlayerInstance, Convert.ToInt32(spawnDef.X), Convert.ToInt32(spawnDef.Y), spawnDef);
                    spawnObjects.Add(spawnObject);
                }
            }

            return spawnObjects;
        }
    }
}
