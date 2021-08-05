using System;

namespace Enemies
{
    public class Zombie
    {
        private int health;
        public Zombie()
        {
            health = 0;
        }
        public Zombie(int value)
        {
            if (value >= 0)
            {
                health = value;
            }
            else
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
        }
        private string name = "(No name)";
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }

        }
        public int GetHealth()
        {
            return health;
        }
        public override string ToString()
        {
            return string.Format("Zombie Name: {0} / Total Health: {1}", name, health);
        }
    }
}
