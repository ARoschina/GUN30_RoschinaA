using static System.Net.Mime.MediaTypeNames;

namespace Homework4_Basic_RPG
{
    public class Combat
    {
        List<Rate> rates;
        private float _health1;
        private float _health2;

        public Combat()
        {
            rates = new List<Rate>();
        }

        public void StartCombat(Unit unit1, Unit unit2)
        {
            _health1 = unit1.RealHealth();
            _health2 = unit2.RealHealth();
            do
            {
                if (new Random().Next(0, 10) % 2 == 0)
                {
                    // Unit 1 is under attack
                    _health1 -= unit2.GetDamage();
                    Rate rate = new Rate(unit2, unit2.GetDamage(), _health1);
                    rates.Add(rate);
                }
                else
                {
                    // Unit 2 is under attack
                    _health2 -= unit1.GetDamage();
                    Rate rate = new Rate(unit1, unit1.GetDamage(), _health2);
                    rates.Add(rate);
                }
            } while (_health1 > 0 && _health2 > 0);
        }

        public void ShowResults()
        {
            for (int i = 0; i < rates.Count(); i++)
            {
                Console.WriteLine($"Warrior {rates[i].Unit.Name} dealt {rates[i].Damage} damage. The other warrior has {rates[i].Health} health left");
            }
            //Console.WriteLine($"Warrior {} dealt {} damage and has {} health left");
        }
    }
}
