using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dungeonCrawler_TP
{
    internal class RemoveHP : ITriggerable
    {
        public void Trigger(Characteristics attack, Characteristics defense)
        {
            defense.Healthpoints -= attack.Attack;
        }
    }
}