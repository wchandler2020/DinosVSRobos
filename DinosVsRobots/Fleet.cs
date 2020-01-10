using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinosVsRobots
{
    class Fleet
    {
        Weapon robotWeapon = new Weapon("");

        public void robotInit()
        {
            //List of avaibla robots to use.
            List<Robot> RobotList = new List<Robot>() {
                new Robot("T-1000", 100, "shotgun"),
                new Robot("Megatron", 100, "plasmaRifle"),
                new Robot("Johnny Five", 100, "laser")
            };
            
           
            Console.WriteLine("Please choose your warrior: ");
            
            for (int i = 0; i < RobotList.Count; i++)
            {
                Console.WriteLine(i + 1 + ". " + RobotList[i].robotName);
            }

            int userChoice = int.Parse(Console.ReadLine());
            Console.ResetColor();
            Console.WriteLine("Awesome you have chosen " + RobotList[userChoice - 1].robotName + ". His main weapon is a " + RobotList[userChoice - 1].weapon.weaponType + " and currently his health is " + RobotList[userChoice -1].robotHealth +".");
            Console.ReadLine();
        }
    }
}
