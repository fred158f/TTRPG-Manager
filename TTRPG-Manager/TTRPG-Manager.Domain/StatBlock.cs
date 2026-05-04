using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTRPG_Manager.Domain
{
    public class StatBlock
    {
        public Stat Strength { get; set; }
        public Stat Dexterity { get; set; }
        public Stat Intelligence { get; set; }
        public Stat Wisdom { get; set; }
        public Stat Charisma { get; set; }
        public Stat Constitution { get; set; }
    }
}
