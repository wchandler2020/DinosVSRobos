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
        Herd dino1 = new Herd();
       
        public Robot robotInit()
        {
            //List of avaibla robots to use.
            List<Robot> RobotList = new List<Robot>() {
                new Robot("T-1000", 100, new Weapon("Shotgun")),
                new Robot("Megatron", 100, new Weapon("Plasma Cannon")),
                new Robot("Johnny Five", 100, new Weapon("Laser Attack"))
            };
            
           
            Console.WriteLine("Please choose your warrior: ");
            
            for (int i = 0; i < RobotList.Count; i++)
            {
                Console.WriteLine(i + 1 + ". " + RobotList[i].robotName);
            }

            //if input is enter as "ENTER" will return an exception for 
            int userChoice = int.Parse(Console.ReadLine());

            if(userChoice == 1)
            {
                Console.ResetColor();
                Console.WriteLine("Awesome you have chosen " + RobotList[userChoice - 1].robotName + ". His main weapon is a " + RobotList[userChoice - 1].weapon.weaponName + " and currently his health is " + RobotList[userChoice - 1].robotHealth + ".");
                return RobotList[userChoice - 1];
            }else if(userChoice == 2)
            {
                Console.ResetColor();
                Console.WriteLine("Awesome you have chosen " + RobotList[userChoice - 1].robotName + ". His main weapon is a " + RobotList[userChoice - 1].weapon.weaponName + " and currently his health is " + RobotList[userChoice - 1].robotHealth + ".");
                return RobotList[userChoice - 1];
            }else if(userChoice == 3)
            {
                Console.ResetColor();
                Console.WriteLine("Awesome you have chosen " + RobotList[userChoice - 1].robotName + ". His main weapon is a " + RobotList[userChoice - 1].weapon.weaponName + " and currently his health is " + RobotList[userChoice - 1].robotHealth + ".");
                return RobotList[userChoice - 1];
            }
            else
            {
                Console.WriteLine("I am sorry that is not an option. ");
                return robotInit();
            }
            


        }
      public Dinosaur opponentSelect()
        {
            Console.WriteLine("Choose your worthy opponent: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Dinosaur dinosaur = dino1.dinoInit();
            Console.ResetColor();
            return dinosaur;

            //int userSelect = int.Parse(Console.ReadLine());
            //if(userSelect == 1)
            //{
            //    Console.WriteLine("You have chosen Barney, while goofy a very worthy opponent!" );
            //    Console.ReadLine();
            //}else if (userSelect == 2)
            //{
            //    Console.WriteLine("You have chosen the terror of Jurrasic Park T-Rex as your opponent!");
            //    Console.ReadLine();
            //}else if(userSelect == 3)
            //{
            //    Console.WriteLine("You have chosen the pride of Bedrock, Dino the dinosaur dog!");
            //    Console.ReadLine();
            //}
            //else
            //{
            //    //need authentication
            //}
        }  
    }
}
