using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinosVsRobots
{
    class Robot
    {
        public string robotName;
        public int robotHealth;
        public int robotPowerLevel;
        public Weapon weapon;

        public Robot(string robotName, int robotHealth, string weaponType)
        {
            this.robotName = robotName;
            this.robotHealth = robotHealth;
            weapon = new Weapon(weaponType);
        }
    }
}
