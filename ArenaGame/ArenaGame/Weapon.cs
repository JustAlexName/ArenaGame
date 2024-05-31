using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    namespace ArenaGame
    {
        public class Weapon
        {
            public string Name { get; private set; }
            public int DamageBoost { get; private set; }
            public int AbilityChance { get; private set; }

            public Weapon(string name, int damageBoost, int abilityChance)
            {
                Name = name;
                DamageBoost = damageBoost;
                AbilityChance = abilityChance;
            }

            public virtual int ApplyAbility(int baseDamage)
            {
                return baseDamage;
            }

        }
    }

