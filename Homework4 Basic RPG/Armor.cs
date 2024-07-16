using System.Xml.Linq;
using static System.Reflection.Metadata.BlobBuilder;

namespace Homework4_Basic_RPG
{
    // Armor
    public class Armor
    {
        //Helm
        public class Helm
        {
            string name = "Helm";
            float defence = 0f;

            public string Name
            {
                get => name;
            }
            public float Defence
            {
                get => defence;
                set
                {
                    defence = value;
                    if (defence < 0)
                    {
                        defence = 0;
                    }
                    else if (defence > 1)
                    {
                        defence = 1;
                    }
                }
            }

            public Helm(string name, float defence)
            {   
                this.defence = defence;
            }
        }

        // Shell
        public class Shell
        {
            string name = "Shell";
            float defence = 0f;

            public string Name
            {
                get => name;
            }
            public float Defence
            {
                get => defence;
                set
                {
                    defence = value;
                    if (defence < 0)
                    {
                        defence = 0;
                    }
                    else if (defence > 1)
                    {
                        defence = 1;
                    }
                }
            }

            public Shell(string name, float defence)
            {                
                this.defence = defence;
            }
        }

        // Boots
        public class Boots
        {
            string name = "Boots";
            float defence = 0f;

            public string Name
            {
                get => name;
            }
            public float Defence
            {
                get => defence;
                set
                {
                    defence = value;
                    if (defence < 0)
                    {
                        defence = 0;
                    }
                    else if (defence > 1)
                    {
                        defence = 1;
                    }
                }
            }

            public Boots(string name, float defence)
            {                
                this.defence = defence;
            }
        }
    }
}
