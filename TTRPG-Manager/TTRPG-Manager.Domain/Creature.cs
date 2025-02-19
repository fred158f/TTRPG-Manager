using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTRPG_Manager.Domain
{
    public class Creature
    {
        readonly string name = "";
        int hitpoints = 0;
        //string description = "";
        
        public StatBlock Stats { get; }
        public int Initiative { get; set; }

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
