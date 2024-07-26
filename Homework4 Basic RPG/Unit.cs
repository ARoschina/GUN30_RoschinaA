using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4_Basic_RPG
{
    public class Unit
    {
        private string name;
        private float health;
        private float realHealth;
        public float baseDamage = 5;
        private float baseArmor = 0f;
        private Armor.Helm _helm;
        private Armor.Shell _shell;
        private Armor.Boots _boots;

        // Giving the unit a name
        public string Name
        {
            get => name;
        }

        // Giving the unit health
        public float Health
        {
            get => health;
        }

        // Getting variables from outside
        public Unit()
        {
            this.name = "Unknown Unit";
        }
        public Unit(string name) : this(name, 10f)
        {
        }
        public Unit(string name, float health)
        {
            this.name = name;
            this.health = health;
        }

        // Constructing health
        public float RealHealth()
        {
            if (_helm != null && _shell != null && _boots != null)
            {
                realHealth = health * (1 + _helm.Defence + _shell.Defence + _boots.Defence);
                return realHealth;
            } 
            else return realHealth = health;
        }

        // Receive damage
        public bool SetDamage(float inDamage)
        {
            if ((realHealth - inDamage / (1 + _helm.Defence + _shell.Defence + _boots.Defence)) > 0)
            {
                return false; // The unit is alive
            }
            else return true; // The unit is dead            
        }

        // Giving the unit a weapon
        private Weapon _weapon;
        public void EquipWeapon(Weapon weapon)
        {
            _weapon = weapon;
        }

        // Calculating damage of the unit
        public float GetDamage()
        {
            if (_weapon == null)
            {
                return baseDamage;
            }
            return baseDamage + _weapon.GetDamage();
        }

        // Giving the unit armour      
        public void EquipHelm(Armor.Helm helm)
        {
            _helm = helm;
        }

        public void EquipShell(Armor.Shell shell)
        {
            _shell = shell;
        }

        public void EquipBoots(Armor.Boots boots)
        {
            _boots = boots;
        }

        // Print the unit info
        public void Print()
        {
            Console.WriteLine("\nYour warrior's name is: " + name);
            Console.WriteLine("\nYour warrior's health is: " + realHealth);
            Console.WriteLine("\nYour warrior damage is: " + GetDamage());
        }
    }
}
