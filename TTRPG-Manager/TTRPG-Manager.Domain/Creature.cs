namespace TTRPG_Manager.Domain
{
    public enum CreatureType
    {
        Humanoid,
        Monstrosity,
        Fiend,
        Undead,
        Goblonoid,
        Beast
    }

    public enum CharacterType
    {
        Player,
        Enemy,
        NPC,
        NbrOfItems
    }

    public class Creature
    {
        readonly string name = "";
        int hitpoints = 0;
        
        public StatBlock Stats { get; }
        public int Initiative { get; set; }
        public CharacterType ChType { get; set; }
        public CreatureType CrType { get; set; }

        public Creature(int hp, StatBlock _stats, string _name)
        {
            hitpoints = hp;
            Stats = _stats;
            name = _name;
        }

        public string GetName() => name;
        public int GetHP() => hitpoints;
        public void ModifyHealth(int value) => hitpoints += value;
    }
}
