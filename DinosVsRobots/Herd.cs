using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinosVsRobots
{
    class Herd
    {
        public void dinoInit()
        {
            //List of avaibla robots to use.
            List<Dinosaur> DinoList = new List<Dinosaur>() {
                new Dinosaur("Barney", 100, "Annoying Song"),
                new Dinosaur("T-Rex", 100, "Bite"),
                new Dinosaur("Dino", 100, "No Clue")
            };


            Console.WriteLine("Please choose your Dino: ");

            for (int i = 0; i < DinoList.Count; i++)
            {
                Console.WriteLine(i + 1 + ". " + DinoList[i].dinoName);
            }

            int userChoice = int.Parse(Console.ReadLine());
            Console.ResetColor();
            Console.WriteLine("Awesome you have chosen " + DinoList[userChoice - 1].dinoName + " and currently his health is " + DinoList[userChoice - 1].dinoHealth + ".");
            Console.ReadLine();
        }
    }
}
