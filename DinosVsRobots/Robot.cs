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
        public double robotAttack;
        public Weapon weapon;

        public Robot(string robotName, int robotHealth, Weapon weapon)
        {
            this.robotName = robotName;
            this.robotHealth = robotHealth;
            this.weapon = weapon;
        }

        public void roboWeaponAttack(Dinosaur dinosaur)
        {
           dinosaur.dinoHealth -= weapon.weaponsAttack();
        }
    }
}
