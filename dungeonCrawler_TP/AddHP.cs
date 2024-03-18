using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dungeonCrawler_TP
{
    internal class AddHP : ITriggerable
    {
        public void Trigger(Characteristics attack, Characteristics defense)
        {
            double healPower = (double)attack.Healthpoints * 0.1;
            attack.Healthpoints += (int)healPower;
        }
    }
}
