using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Mage : Hero
    {
        private const int DracoreLibre = 13;
        public Mage(string name, Weapon weapon) : base (name, weapon) { }
        public override int  Attack()
        {
            int attack = base.Attack();

            if (ThrowDice(DracoreLibre))
            {
                attack = attack * 4;
            }
            return attack;
        }
        public override void TakeDamage(int incomingDamage)
        {
            base.TakeDamage(incomingDamage);
        }
    }
}
