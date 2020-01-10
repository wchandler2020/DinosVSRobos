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
        public string weaponType;
        public string attackPower;

        public Robot(string robotName)
        {
            this.robotName = robotName;
        }
    }
}
