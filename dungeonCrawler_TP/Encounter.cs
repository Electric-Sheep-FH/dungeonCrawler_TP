using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dungeonCrawler_TP
{
    internal abstract class Encounter
    {
        public string Name { get; set; }

        protected Encounter(string name)
        {
            Name = name;
        }

        public abstract void EncounterEffect(Adventurer adventurer);
    }
}
