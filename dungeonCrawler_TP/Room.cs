using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dungeonCrawler_TP
{
    internal class Room
    {
        public List<Encounter> PossibleEncounter { get; set; }
        public Room(List<Encounter> possibleEncounter)
        {
            PossibleEncounter = possibleEncounter;
        }
    }
}