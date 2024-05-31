using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class Archer : Hero
    {
        private const int Dreamdiver = 27;

        public Archer(string name, Weapon weapon) : base(name, weapon) { }

        public override int Attack()
        {
            return base.Attack();
        }

        public override void TakeDamage(int incomingDamage)
        {
            if (ThrowDice(Dreamdiver))
            {
                incomingDamage = 0;
            }
            base.TakeDamage(incomingDamage);
        }
    }
}
