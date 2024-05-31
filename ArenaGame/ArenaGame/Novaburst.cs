using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Novaburst : Weapon
    {
        private const int BurnChance = 15;
        private const int BurnDamage = 35;
        public Novaburst(): base("Novaburst" , 20, BurnChance){ }
        public override int ApplyAbility(int baseDamage)
        {
            if (Random.Shared.Next(100) < AbilityChance)
            {
                Console.WriteLine("Novaburst inflicts burn damage!");
                return baseDamage + BurnDamage;
            }
            return baseDamage;
        }
    }
}
