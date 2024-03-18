using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dungeonCrawler_TP
{
    internal class Item : Encounter
    {
        public ItemType Type { get; set; }
        public int CaracBuff { get; set; }
        public Item(string name, ItemType type, int caracBuff) : base(name)
        {
            Type = type;
            CaracBuff = caracBuff;
        }

        public override void EncounterEffect(Adventurer adventurer)
        {
            Console.WriteLine("Vous tombez sur un objet étrange...");
            if (Type == ItemType.Speed)
            {
                Console.WriteLine($"\"{Name}\" qui augmente votre vitesse de {CaracBuff} points !");
                adventurer.CharacterCarac.Speed += CaracBuff;
            } else if (Type == ItemType.Attack)
            {
                Console.WriteLine($"\"{Name}\" qui augmente votre attaque de {CaracBuff} points !");
                adventurer.CharacterCarac.Attack += CaracBuff;
            } else
            {
                Console.WriteLine($"\"{Name}\" qui vous soigne de {CaracBuff} points de vie !");
                adventurer.CharacterCarac.Healthpoints += CaracBuff;
            }
            Console.WriteLine("######################################\n");
            Console.WriteLine();
        }




    }
}
