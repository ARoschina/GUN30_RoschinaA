namespace Homework4_Basic_RPG
{
    public struct Interval
    {
        public float Min { get; set; }
        public float Max { get; set; }
       
        public Interval(int min, int max) : this((float) min, max)
        { }
        public Interval(float min, float max)
        { 
            Min = min;
            Max = max;

            if (Min > Max)
            {
                (Min, Max) = (Max, Min);            // swap values
            }
        }

        public Interval(float value)
        {
            Min = value;
            Max = value;
        }

        public float Get()
        {
            Random random = new Random();                               // Making random float from set interval ---line 1
            return (float) random.NextDouble() * (Max - Min) + Min;     // ---line 2    
        }
        public float Average()
        {
            return (float) (Max + Min) / 2;
        }
    }
}
