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

            // Giving weapon. Old version
            /*float minDamage = 0f;

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
            */

            // Giving weapon. New version
            Console.WriteLine("\nWhat's your weapon minimum and maximum damage? (from 0 to 40):");
            var numbers = new List<int>();
            do
            {
                foreach (string s in Console.ReadLine().Split())
                {
                    if (int.TryParse(s, out int number))
                    {
                        numbers.Add(number);
                    }
                    else
                    {
                        Console.WriteLine("Wrong number! Try again.");
                    }
                }
            } while (numbers.Count < 2);

            Weapon newWeapon = new Weapon(numbers[0], numbers[1]);
            
            // Printing info
            playerUnit.Print();


            /*// Receiving damage - Old Version
            Console.WriteLine("\nYour warrior receives damage.");
            if (playerUnit.SetDamage(new Random().Next(0, 50)) == true)
            {
                Console.WriteLine("Your warrior is dead!");
            }
            else
            {
                Console.WriteLine("Your warrior is still alive!");
            }*/

            // Creating fighting Units
            Unit unit1 = new Unit("Big", 100);
            Unit unit2 = new Unit("Small", 50);

            unit1.baseDamage = 25;
            unit2.baseDamage = 15;

            Console.WriteLine($"Your warriors are: {unit1.Name} and {unit2.Name}");

            Combat combat = new Combat();
            Console.WriteLine("Fight begins!");
            combat.StartCombat(unit1, unit2);            
            combat.ShowResults();
            Console.WriteLine("Fight is over!");

        }
    }



}
