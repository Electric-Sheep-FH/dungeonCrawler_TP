using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dungeonCrawler_TP
{
    internal class Characteristics
    {
        public int Healthpoints { get; set; }
        public int Attack { get; set; }
        public int Speed { get; set; }
        public Characteristics(int healthpoints, int attack, int speed)
        {
            Healthpoints = healthpoints;
            Attack = attack;
            Speed = speed;
        }
    }
}
