namespace ArenaGame
{
    public class Hero
    {
        public string Name { get; private set; }

        public int Health { get; private set; }

        public int Strength { get; private set; }

        protected int StartingHealth { get; private set; }

        public bool IsDead { get { return Health <= 0; } }
        public Weapon Weapon { get; private set; }

        public Hero(string name, Weapon weapon)
        {
            Name = name;
            Health = 1685;// promeneni ot men 
            StartingHealth = Health;
            Strength = 170;// promeneni ot men 
            Weapon = weapon;
        }

        public virtual int Attack()
        {
            int damage = (Strength * Random.Shared.Next(80, 121)) / 100;
            return Weapon.ApplyAbility(damage + Weapon.DamageBoost);
        }

        public virtual void TakeDamage(int incomingDamage)
        {
            if (incomingDamage < 0) return;
            Health = Health - incomingDamage;
        }

        protected bool ThrowDice(int chance)
        {
            int dice = Random.Shared.Next(101);
            return dice <= chance;
        }

        protected void Heal(int value)
        {
            Health = Health + value;
            if (Health > StartingHealth) Health = StartingHealth;
        }
    }
}
