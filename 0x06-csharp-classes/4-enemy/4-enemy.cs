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
    }
}
