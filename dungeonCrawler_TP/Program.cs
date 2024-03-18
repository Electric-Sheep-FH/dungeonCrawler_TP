namespace dungeonCrawler_TP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Adventurer fab = new Adventurer("Fab", new Characteristics(100, 20, 6), new List<ITriggerable>{new RemoveHP(), new RemoveAttack(), new AddHP()});
            Monster peon = new Monster("Péon", new Characteristics(100, 6, 3), new List<ITriggerable> { new RemoveHP() });
            Monster peonChief = new Monster("Péon en chef", new Characteristics(100,15, 7), new List<ITriggerable> { new RemoveHP(), new AddHP() });

            Trap simpleTrap = new Trap("Piège à cons", new List<ITriggerable> { new RemoveHP()}, new Characteristics(100,8,4));

            Item healthPotion = new Item("Potion de soin", ItemType.Heal, 10);
            Item speedBoost = new Item("Bottes du chevaucheur", ItemType.Speed, 5);
            Item attackBoost = new Item("Epée de feu", ItemType.Attack, 7);

            Room randomRoomSet = new Room(new List<Encounter> { peon, peonChief, simpleTrap, healthPotion, attackBoost, speedBoost });
            Dungeon naheulbeuk = new Dungeon("Donjon de Naheulbeuk", randomRoomSet);

            fab.EnterDungeon(naheulbeuk,5);

        }
    }
}
