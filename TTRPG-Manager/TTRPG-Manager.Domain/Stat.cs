using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTRPG_Manager.Domain
{
    public class Stat
    {
        int value = 0;
        int multiplier = 0;
        int savingthrow = 0;
        int proficiencybonus = 0;

        public Stat(int _value, int _proficiency)
        {
            proficiencybonus = _proficiency;
            UpdateValue(_value);
        }

        public void UpdateValue(int _value)
        {
            value = _value;
            multiplier = -5 + (value / 2);
            savingthrow = multiplier + proficiencybonus;
        }

        public int GetSavingThrow() => savingthrow;
        public int GetValue() => value;
        public int GetMultiplier() => multiplier;
    }
}
