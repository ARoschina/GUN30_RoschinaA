namespace Homework4_Basic_RPG
{
    internal class Program
    {        
        static void Main(string[] args)
        {    
            int intNumberDebug;
            float floatNumberDebug;

            // Naming
            string inputName;

            Console.WriteLine("Give your warrior a name:");     
            do
            {
                inputName = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(inputName) ||  int.TryParse(inputName, out intNumberDebug))       // Foolproofing
                {
                    Console.WriteLine("This is unappropriate. Write a name!");
                }
            } while (string.IsNullOrWhiteSpace(inputName) || int.TryParse(inputName, out intNumberDebug));

            // Giving health
            int inputHealth = 0;

            Console.WriteLine("\nWhat's your warrior's health? (from 10 to 100):");                 
            do
            {
                Console.WriteLine("Write a number from 10 to 100:");
                if (int.TryParse(Console.ReadLine(), out intNumberDebug))
                {
                    if (intNumberDebug >= 10 && intNumberDebug <= 100)
                    {
                        inputHealth = intNumberDebug;
                        break;
                    }
                    else Console.WriteLine("Wrong number!");     // Foolproofing
                }
                else Console.WriteLine("This isn't a number!");      // Foolproofing                
            } while (intNumberDebug < 10 || intNumberDebug > 100);
            
            Unit playerUnit = new Unit(inputName, inputHealth);

            // Giving player unit armour
            // Helm
            float helmDefence = 0f;

             Console.WriteLine("\nWhat's the defence of your helm? (from 0 to 1):");
             do
             {
                 Console.WriteLine("Write a number from 0 to 1:");
                 if (float.TryParse(Console.ReadLine(), out floatNumberDebug))
                 {
                     if (floatNumberDebug >= 0 && floatNumberDebug <= 1)
                     {
                         helmDefence = floatNumberDebug;
                         break;
                     }
                     else Console.WriteLine("Wrong number!");     // Foolproofing
                 }
                 else Console.WriteLine("This isn't a number!");      // Foolproofing                
             } while (floatNumberDebug <= 1 || floatNumberDebug >= 0);

            Armor.Helm newHelm = new Armor.Helm(string.Empty, helmDefence); 

             // Shell
             float shellDefence = 0f;

             Console.WriteLine("\nWhat's the defence of your shell? (from 0 to 1):");
             do
             {
                 Console.WriteLine("Write a number from 0 to 1:");
                 if (float.TryParse(Console.ReadLine(), out floatNumberDebug))
                 {
                     if (floatNumberDebug >= 0 && floatNumberDebug <= 1)
                     {
                         shellDefence = floatNumberDebug;
                         break;
                     }
                     else Console.WriteLine("Wrong number!");     // Foolproofing
                 }
                 else Console.WriteLine("This isn't a number!");      // Foolproofing                
             } while (floatNumberDebug <= 1 || floatNumberDebug >= 0);

            Armor.Shell newShell = new Armor.Shell(string.Empty, shellDefence);

             // Boots
             float bootsDefence = 0f;

             Console.WriteLine("\nWhat's the defence of your boots? (from 0 to 1):");
             do
             {
                 Console.WriteLine("Write a number from 0 to 1:");
                 if (float.TryParse(Console.ReadLine(), out floatNumberDebug))
                 {
                     if (floatNumberDebug >= 0 && floatNumberDebug <= 1)
                     {
                         bootsDefence = floatNumberDebug;
                         break;
                     }
                     else Console.WriteLine("Wrong number!");     // Foolproofing
                 }
                 else Console.WriteLine("This isn't a number!");      // Foolproofing                
             } while (floatNumberDebug <= 1 || floatNumberDebug >= 0);

            Armor.Boots newBoots = new Armor.Boots(string.Empty, bootsDefence);

            playerUnit.EquipHelm(newHelm);
            playerUnit.EquipShell(newShell);
            playerUnit.EquipBoots(newBoots);

            playerUnit.RealHealth();

            // Giving weapon
            float minDamage = 0f;

            Console.WriteLine("\nWhat's your weapon minimum damage? (from 0 to 20):");
            do
            {
                Console.WriteLine("Write a number from 0 to 20:");
                if (float.TryParse(Console.ReadLine(), out floatNumberDebug))
                {
                    if (floatNumberDebug >= 0 && floatNumberDebug <= 20)
                    {
                        minDamage = floatNumberDebug;
                        break;
                    }
                    else Console.WriteLine("Wrong number!");     // Foolproofing
                }
                else Console.WriteLine("This isn't a number!");      // Foolproofing                
            } while (floatNumberDebug < 0 || floatNumberDebug > 20);

            float maxDamage = 0f;

            Console.WriteLine("\nWhat's your weapon maximum damage? (from 20 to 40):");
            do
            {
                Console.WriteLine("Write a number from 20 to 40:");
                if (float.TryParse(Console.ReadLine(), out floatNumberDebug))
                {
                    if (floatNumberDebug >= 20 && floatNumberDebug <= 40)
                    {
                        maxDamage = floatNumberDebug;
                        break;
                    }
                    else Console.WriteLine("Wrong number!");     // Foolproofing
                }
                else Console.WriteLine("This isn't a number!");      // Foolproofing                
            } while (floatNumberDebug < 20 || floatNumberDebug > 40);

            Weapon newWeapon = new Weapon(string.Empty, minDamage, maxDamage);
            playerUnit.EquipWeapon(newWeapon);
                      

            // Printing info
            playerUnit.Print();


            // Receiving damage    
            Console.WriteLine("\nYour warrior receives damage.");
            if (playerUnit.SetDamage(new Random().Next(0, 50)) == true)
            {
                Console.WriteLine("Your warrior is dead!");
            }
            else
            {
                Console.WriteLine("Your warrior is still alive!");
            }
        }
    }

    // Unit stats
    public class Unit
    {
        public string name;
        public float health;
        public float realHealth;
        public float baseDamage = 5;
        public float baseArmor = 0f;
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
        public Unit(string name = "Unknown Unit", float health = 10f)
        {
            this.name = name;
            this.health = health;
        }

        // Constructing health
        public float RealHealth()
        {
            realHealth = health * (1 + _helm.Defence + _shell.Defence + _boots.Defence);            
            return realHealth;
        }

        // Receive damage
        public bool SetDamage(float inDamage)
        {
            if ((realHealth - inDamage/(1 + _helm.Defence + _shell.Defence + _boots.Defence)) > 0)
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
