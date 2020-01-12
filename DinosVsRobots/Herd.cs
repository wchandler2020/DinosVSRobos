using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinosVsRobots
{
    class Herd
    {
        public Dinosaur dinoInit()
        {
            //List of avaibla robots to use.
            List<Dinosaur> DinoList = new List<Dinosaur>() {
                new Dinosaur("Barney", 100, new Weapon("Annoying Song")),
                new Dinosaur("T-Rex", 100, new Weapon("Bite")),
                new Dinosaur("Dino", 100, new Weapon("Headbutt"))
            };

            for (int i = 0; i < DinoList.Count; i++)
            {
                Console.WriteLine(i + 1 + ". " + DinoList[i].dinoName );
            }

            int userChoice = int.Parse(Console.ReadLine());
            Console.ResetColor();
            Console.WriteLine("Awesome you have chosen " + DinoList[userChoice - 1].dinoName + " and currently his health is " + DinoList[userChoice - 1].dinoHealth + "." + " Be careful to avoid his " + DinoList[userChoice - 1].weapon.weaponName);
            Console.ReadLine();
            return DinoList[userChoice - 1];
        }
    }
}
