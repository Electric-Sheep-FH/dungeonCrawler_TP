using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dungeonCrawler_TP
{
    internal class RemoveAttack : ITriggerable
    {
        public void Trigger(Characteristics player, Characteristics monster)
        {
            int attackDebuff = player.Attack / 4;
            int attack = player.Attack/3;

            monster.Attack -= attackDebuff;
            monster.Healthpoints -= attack;

            Console.WriteLine($"Vous attaquez le monstre et lui infligé {attack} de dégats. Vous réduisez aussi son attaque de {attackDebuff}.");
        }
    }
}
