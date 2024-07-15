
namespace Homework4_Basic_RPG
{
    public class Weapon
    {
        public string name;
        public float minDamage;
        public float maxDamage;
        public float damage;

        public Weapon()
        {
            name = "Weapon1";            
        }

        public Weapon(string name, float minDamage, float maxDamage)
        {
            this.name = name;
            this.minDamage = minDamage;
            this.maxDamage = maxDamage;
            SetDamageParams(this.minDamage, this.maxDamage);
        }

        public void SetDamageParams(float minDamage, float maxDamage)
        {
            if (minDamage > maxDamage)
            {
                (minDamage, maxDamage) = (maxDamage, minDamage);
                Console.WriteLine($"\nYour parameters for {name} have been swapped to match minimum to minimum damage and maximum to maximum one.");
            }

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

            this.minDamage = minDamage;
            this.maxDamage = maxDamage;
        }

        public float GetDamage()
        {
            damage = (minDamage + maxDamage) / 2;            
            return damage;
        }
    }
}
