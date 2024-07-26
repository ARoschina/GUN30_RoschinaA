
namespace Homework4_Basic_RPG
{
    public class Weapon
    {
        Interval interval;
        private float damage;
        private float minDamage;
        private float maxDamage;
        public string Name 
        { 
            get; 
        }

        public Weapon(string name)
        {
            Name = name;            
        }

        public Weapon(string name, float minDamage, float maxDamage) : this (name = "Unnamed weapon")
        {            
            SetDamageParams(this.minDamage, this.maxDamage);
        }
        public Weapon(float minDamage, float maxDamage)
        {
            this.Name = "Unnamed weapon";
            SetDamageParams(this.minDamage, this.maxDamage);
        }

        public void SetDamageParams(float minDamage, float maxDamage)
        {
            if (minDamage < 1) 
            {
                 minDamage = 1;
                 Console.WriteLine("Minimum damage is set to " + minDamage);
            }

            if (maxDamage < 1) 
            {
                maxDamage = 10;
                Console.WriteLine("Maximum damage is set to " + maxDamage);
            }
            interval = new Interval(minDamage, maxDamage);
        }

        public float GetDamage()
        {
            damage = (interval.Min + interval.Max) / 2;

            // Check if damage is bigger than 30
            if (damage > 30)
            {
                damage = 30;
            }

            return damage;
        }
    }
}
