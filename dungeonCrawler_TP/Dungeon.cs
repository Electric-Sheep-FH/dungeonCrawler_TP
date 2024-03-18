using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace dungeonCrawler_TP
{
    internal class Dungeon
    {
        public string DungeonName { get; set; }
        public Room DungeonRooms { get; set; }
        public Adventurer Adventurer { get; set; }

        public Dungeon(string dungeonName, Room dungeonRooms)
        {
            DungeonName = dungeonName;
            DungeonRooms = dungeonRooms;
        }

        public void WanderRooms(Adventurer adventurer, int NumberOfRooms)
        {
            Random random = new Random();
            for (int i = 0; i < NumberOfRooms; i++)
            {
                int randomRoom = random.Next(0,101);
                Console.WriteLine($"Vous pénétrez dans la pièce n°{i+1}.");
                Console.WriteLine("######################################");
                if (randomRoom >= 60)
                {
                    randomRoom = random.Next(0, 101);
                    if (randomRoom >= 50)
                    {
                        DungeonRooms.PossibleEncounter[3].EncounterEffect(adventurer);
                    }
                    else if (randomRoom >= 25)
                    {
                        DungeonRooms.PossibleEncounter[5].EncounterEffect(adventurer);
                    }
                    else
                    {
                        DungeonRooms.PossibleEncounter[4].EncounterEffect(adventurer);
                    }
                }
                else if (randomRoom >= 30)
                {
                    DungeonRooms.PossibleEncounter[2].EncounterEffect(adventurer);
                }
                else
                {
                    randomRoom = random.Next(0, 101);
                    if (randomRoom >= 25)
                    {
                        DungeonRooms.PossibleEncounter[0].EncounterEffect(adventurer);
                    }
                    else
                    {
                        DungeonRooms.PossibleEncounter[1].EncounterEffect(adventurer);
                    }

                }

                if (adventurer.CharacterCarac.Healthpoints <= 0)
                {
                    Console.WriteLine("Oh diantre ! Vous êtes mort... Fin de la partie.");
                    break;
                }
                Thread.Sleep(1000);

            }
        }
    }
}
