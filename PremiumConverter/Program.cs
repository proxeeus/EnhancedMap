using EnhancedMap.Core;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PremiumConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var showMenu = true;

            while(showMenu)
            {
                showMenu = MainMenu();
            }
        }

        static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Premium Spawner Converter");
            Console.WriteLine("==========================");
            Console.WriteLine("Choose an option:");
            Console.WriteLine("");
            Console.WriteLine("1) Convert a single PremiumSpawner .map to an UOSpawner .map");
            Console.WriteLine("2) Batch convert (parses a directory for all .map files inside and converts them).");
            Console.WriteLine("3) Validate .map file against the scripts core");
            Console.WriteLine("Q) Quit");

            switch(Console.ReadLine().ToLower())
            {
                case "1":
                    Convert();
                    return true;
                case "2":
                    BatchConvert();
                    return true;
                case "3":
                    Check();
                    return true;
                case "q":
                    return false;
                default:
                    return true;
            }
        }

        static void BatchConvert()
        {
            Console.Clear();
            Console.WriteLine("Enter the directory containing the .map files:");
            var premiumPath = Console.ReadLine();

            var rootMapDir = new DirectoryInfo(premiumPath);
            foreach (var file in rootMapDir.GetFiles("*.map"))
                ConvertSingleFile(file.FullName);

            Console.WriteLine("Done!");
            Console.ReadLine();
        }

        /// <summary>
        /// The actual file conversion method.
        /// </summary>
        /// <param name="premiumPath"></param>
        static void ConvertSingleFile(string premiumPath)
        {
            if (File.Exists(premiumPath))
            {
                Console.WriteLine("Now reading from '{0}'...", premiumPath);
                Console.WriteLine();
                using (var streamReader = new StreamReader(premiumPath))
                {
                    var line = string.Empty;
                    var mapFileInfo = new FileInfo(premiumPath);

                    var spawnDefs = new List<SpawnDefinition>();

                    while ((line = streamReader.ReadLine()) != null)
                    {
                        if (Helpers.IgnoreLine(line)) continue;
                        Console.WriteLine("Converting '{0}'", line);
                        var splitData = line.Split('|');
                        if (!Helpers.HasObjectsToSpawn(splitData))
                            Console.WriteLine("WARNING: Line '{0}' has no spawn data, skipping...", line);
                        else
                        {
                            /*
                             * Here's the rough format of the various .map files across distros, with a couple of sample entries to better visualize.
                             * Array indexes are above the colum names
                             
    1        2   3  4    5   6   7    8    9    10      11      12       13         14        15      16        17          18          19          20          21
*|typename |s1 |s2 |s3 |s4 |s5 | x  | y  | z | map | mindelay maxdelay homerange spawnrange spawnid maxcount | maxcount1 | maxcount2 | maxcount3 | maxcount4 | maxcount5
*|Herbalist|   |   |   |   |   |1685|2985|0  |1    |5       |10       |20       |10         |1     |2        |0			 |0			 |0			 |0			 |0
*|Ratmanmage|||||			   |5850|219 |-3 |2	   |5	    |10       |20       |10         |1     |1        |0          |0          |0          |0          |0

                            */


                            var spawnDef = new SpawnDefinition();

                            Helpers.AddSpawnTypesToDefinition(splitData, spawnDef);
                            if (spawnDef.Mobiles.Count > 6)
                                Console.WriteLine("WARNING: '{0}' currently defines more than 6 mobiles!", line);

                            spawnDef.SpawnerName = mapFileInfo.Name + "_" + splitData[1];
                            spawnDef.X = splitData[7];
                            spawnDef.Y = splitData[8];
                            spawnDef.MapId = splitData[10];
                            spawnDef.MinTime = splitData[11];
                            spawnDef.MaxTime = splitData[12];
                            spawnDef.Team = "0";  // Hardcoded for now, not sure what this does
                            spawnDef.NPCCount = splitData[16];
                            spawnDef.HomeRange = splitData[13];
                            spawnDef.BringToHome = true; // WARNING: for mobs it can be "ok" to have them spawn around the spawner. But for a clump of items, this sucks.

                            spawnDefs.Add(spawnDef);
                        }
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Done parsing '{0}', {1} spawners converted.", mapFileInfo.Name, spawnDefs.Count);
                    var convertedMapFile = "converted_" + mapFileInfo.Name;
                    Console.WriteLine("Now generating '{0}'...", convertedMapFile);

                    var spawnWriter = new SpawnWriter();
                    Helpers.Write(spawnDefs, convertedMapFile);
                    Console.WriteLine("'{0}' created successfully!", convertedMapFile);
                }
            }
            else
            {
                Console.WriteLine("Error: file doesn't exist!");
            }
        }

        /// <summary>
        /// Asks for a .map path, processes it, and creates a Proxeeus .map file.
        /// </summary>
        static void Convert()
        {
            Console.Clear();
            Console.WriteLine("Enter the path of the Premium Spawner .map file:");
            var premiumPath = Console.ReadLine();

            ConvertSingleFile(premiumPath);

            Console.WriteLine("Done!");
            Console.ReadLine();
        }

        /// <summary>
        /// Checks a Proxeeus .map file for any missing types from Items / Mobiles scripts against a given pre-compiled RunUO script core.
        /// </summary>
        static void Check()
        {
            Console.Clear();
            Console.WriteLine("Loading RunUO script core from");
            Console.WriteLine("'{0}'", ConfigurationManager.AppSettings["RunUOCore"]);
            Console.WriteLine("Successfully loaded assembly!");
            Console.WriteLine("");
            Console.WriteLine("Enter the path of the Premium Spawner .map file:");
            var scriptCore = Assembly.LoadFrom(ConfigurationManager.AppSettings["RunUOCore"]);
            var mapPath = Console.ReadLine();

            var types = Helpers.LoadSpawnTypesFrom(mapPath);
            var partialMatches = new List<string>();
            foreach (var type in types)
            {
                var found = false;
                var partialMatch = false;
                var currentCorePartialMatch = string.Empty;
                
                foreach (var coreType in scriptCore.DefinedTypes)
                {
                    if (coreType.Name == type)
                    {
                        found = true;
                        break;
                    }
                        
                    if (coreType.Name.Equals(type, StringComparison.CurrentCultureIgnoreCase))
                    {
                        partialMatch = true;
                        currentCorePartialMatch = coreType.Name;
                        partialMatches.Add(currentCorePartialMatch);
                    }
                        
                }

                if(partialMatch)
                    Console.WriteLine("Type '{0}' doesn't exist in the assembly, closest match found: '{1}'.", type, currentCorePartialMatch);
                else if (!found)
                    Console.WriteLine("Type '{0}' doesn't exist in the assembly.", type);
            }

            if(partialMatches.Count>0)
            {
                Console.WriteLine("Found {0} partial matches. Do you want to attempt to fix those? (y/n)", partialMatches.Count);

                var answer = Console.ReadLine();
                switch(answer.ToLower())
                {
                    case "y":
                        Helpers.FixDataTypes(mapPath, partialMatches);
                        break;
                }
            }

            Console.WriteLine("Done!");
            Console.ReadLine();
        }
    }
}
