using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dungeonCrawler_TP
{
    internal class Adventurer
    {
        public string Name { get; set; }
        public Characteristics CharacterCarac { get; set; }
        public List<ITriggerable> Power { get; set; }

        public Adventurer(string name, Characteristics characterCarac, List<ITriggerable> power)
        {
            Name = name;
            CharacterCarac = characterCarac;
            Power = power;
        }

        public void EnterDungeon(Dungeon dungeon, int NumberOfRooms)
        {
            Console.WriteLine($"{Name} entre dans {dungeon.DungeonName}. Cette instance est composée de {NumberOfRooms} pièces. Bonne chance... \n");
            dungeon.WanderRooms(this,NumberOfRooms);
            if (CharacterCarac.Healthpoints > 0)
            {
                Console.WriteLine("Félicitation, vous êtes venu à bout du donjon !");
            }
        }

    }
}
