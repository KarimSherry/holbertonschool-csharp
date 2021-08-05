using System;

namespace Enemies
{
    ///<summary>Creation of public class Zombie</summary>
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
        public int GetHealth()
        {
            return health;
        }
    }
}
