using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinosVsRobots
{
    class Robot
    {
        public int robotHealth = 100;
        public double weaponStrength;

        public string robotName;
        public int robotPowerLevel;
        public int robotAttackPower;
        public string robotWeaponType;

        public Robot(string robotName, int robotPowerLevel, int robotAttackPower, string robotWeaponType)
        {
            this.robotName = robotName;
            this.robotPowerLevel = robotPowerLevel;
            this.robotAttackPower = robotAttackPower;
            this.robotWeaponType = robotWeaponType;
        }

        public void swordAttack()
        {
            Random randomNum = new Random();
            int swordDamage = randomNum.Next(1, 10);
            Console.WriteLine($"You have attacked using a sword!!! You did {swordDamage} damage points.");
            Console.ReadLine();
        }

        public void shotgunAttack()
        {
            Random randomNum = new Random();
            int shotgunDamage = randomNum.Next(1, 10);
            Console.WriteLine($"You have attacked using a sword!!! You did {shotgunDamage} damage points.");
            Console.ReadLine();
        }

        public void laserAttack()
        {
            Random randomNum = new Random();
            int laserDamage = randomNum.Next(1, 8);
            weaponStrength = laserDamage * 1.2;
            Console.WriteLine($"You have attacked using a sword!!! You did {laserDamage} damage points.");
            Console.ReadLine();
        }


    }
}
