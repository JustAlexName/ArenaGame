using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class LunarCutter : Weapon
    {
        private const int CritRate = 10;
        public LunarCutter(): base ("Lunar Cutter" , 25, CritRate){}
        public override int ApplyAbility (int baseDamage)
        {
            if (Random.Shared.Next(100) < AbilityChance)
            {
                return baseDamage * 2; 
            }
            return baseDamage;
        }

    }

}
