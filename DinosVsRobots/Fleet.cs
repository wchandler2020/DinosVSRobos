using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinosVsRobots
{
    class Fleet
    {
        
        public static void robotInit()
        {

            List<Robot> RobotList = new List<Robot>() {
                new Robot("T-1000"),
                new Robot("Megatron"),
                new Robot("Johnny Five")
            };
            
           
            Console.WriteLine("Choose your warrior.");
            
            for (int i = 0; i < RobotList.Count; i++)
            {

                Console.WriteLine(i + 1 + ". " + RobotList[i].robotName);
            
            }

            int userChoice = int.Parse(Console.ReadLine());

            Console.WriteLine("You have chosen " + RobotList[userChoice - 1].robotName);
            Console.ReadLine(); 
        }
        
        //public Weapon chooseWeapons(Robot robot)
        //{

        //}
    }
}
