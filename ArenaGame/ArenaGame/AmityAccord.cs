using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class AmityAccord : Weapon
    {
        private const int ShieldChance = 15;
        private const int ShieldAmount = 50;
        public AmityAccord() : base("Amity Accord", 15, ShieldChance) { }
        public override int ApplyAbility(int baseDamage)
        {
            if (Random.Shared.Next(50) < AbilityChance )
                {
                    Console.WriteLine("Amity Accord grants a protective shield!");
                    return -ShieldAmount;
                }
                return baseDamage;
        }
    }
}
