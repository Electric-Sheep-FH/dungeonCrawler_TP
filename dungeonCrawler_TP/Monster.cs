using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace dungeonCrawler_TP
{
    internal class Monster : Encounter
    {
        public Characteristics MonsterCharac { get; set; }
        public List<ITriggerable> AttackSet { get; set; }
        public Monster(string name, Characteristics monsterCharac, List<ITriggerable> attackSet) : base(name)
        {
            MonsterCharac = monsterCharac;
            AttackSet = attackSet;
        }

        public void RandomAttack(Adventurer target)
        {
            if (MonsterCharac.Attack <= 0)
            {
                MonsterCharac.Attack = 1;
            }
            if (AttackSet.Count() == 1)
            {
                AttackSet[0].Trigger(MonsterCharac, target.CharacterCarac);

                Console.WriteLine($"\nLe monstre vous attaque à son tour ! Vous perdez {MonsterCharac.Attack} points de vie.\n");
            }
            else
            {
                Random random = new Random();
                int randomAttack = random.Next(0, 101);
                if (randomAttack <= 70)
                {
                    AttackSet[0].Trigger(MonsterCharac, target.CharacterCarac);
                    Console.WriteLine($"\nLe monstre vous attaque à son tour ! Vous perdez {MonsterCharac.Attack} points de vie.\n");
                } else
                {
                    AttackSet[1].Trigger(MonsterCharac, target.CharacterCarac);
                    Console.WriteLine($"Le monstre se soigne de {(int)(MonsterCharac.Healthpoints * 0.1)} !\n");
                }
            }
        }

        public override void EncounterEffect(Adventurer adventurer)
        {
            if (MonsterCharac.Healthpoints <= 0)
            {
                MonsterCharac.Healthpoints = 100;
            }
            Console.WriteLine($"Un enemi est tapis dans l'ombre... Il s'agit de \"{Name}\" !\n");
            if (MonsterCharac.Speed > adventurer.CharacterCarac.Speed)
            {
                AttackSet[0].Trigger(MonsterCharac, adventurer.CharacterCarac);
                Console.WriteLine($"{Name} est plus rapide que vous, il vous attaque et inflige {MonsterCharac.Attack} points de dégats !\n");
            }
            while (MonsterCharac.Healthpoints > 0 && adventurer.CharacterCarac.Healthpoints > 0)
            {
                Console.WriteLine($"Vos PV = {adventurer.CharacterCarac.Healthpoints} ########### PV du monstre = {MonsterCharac.Healthpoints}");
                Console.Write($"Que voulez vous faire :\n1 - Attaque\n2 - Baisser l'attaque de l'ennemi\n3 - Se soigner\n\nVotre choix : ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        adventurer.Power[0].Trigger(adventurer.CharacterCarac, MonsterCharac);
                        Console.WriteLine($"Vous attaquez le monstre et lui infliger {adventurer.CharacterCarac.Attack} dégats !\n");
                        break;
                    case "2":
                        adventurer.Power[1].Trigger(adventurer.CharacterCarac, MonsterCharac);
                        break;
                    case "3":
                        adventurer.Power[2].Trigger(adventurer.CharacterCarac, MonsterCharac);
                        Console.WriteLine($"Vous vous soignez de {(int)(adventurer.CharacterCarac.Healthpoints * 0.1)} points de vie.\n");
                        break;
                }
                if (MonsterCharac.Healthpoints > 0)
                {
                    RandomAttack(adventurer);
                }
                else
                {
                    Console.WriteLine($"\nBravo, vous venez d'abattre {Name}.");
                }
            }
            Console.WriteLine("######################################\n");
        }
    }
}
