namespace Homework4_Basic_RPG
{
    public struct Rate
    {
        public  Unit Unit;
        public float Damage;
        public float Health;

        public Rate(Unit unit, float damage, float health) 
        { 
            Unit = unit; 
            Damage = damage;
            Health = health;
        }
    }
}
