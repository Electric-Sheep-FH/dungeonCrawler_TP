using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dungeonCrawler_TP
{
    internal class Trap : Encounter
    {
        public Characteristics TrapCarac { get; set; }
        public List<ITriggerable> TrapCapacities { get; set; }
        public Trap(string name, List<ITriggerable> trapCapacities, Characteristics trapCarac) : base(name)
        {
            TrapCapacities = trapCapacities;
            TrapCarac = trapCarac;
        }

        public override void EncounterEffect(Adventurer adventurer)
        {
            Console.WriteLine($"Vous mettez le pied sur... \"{Name}\" !");
            TrapCapacities[0].Trigger(TrapCarac, adventurer.CharacterCarac);
            Console.WriteLine($"Vous perdez {TrapCarac.Attack} points de vie !");
            Console.WriteLine("######################################\n");
        }
    }
}
