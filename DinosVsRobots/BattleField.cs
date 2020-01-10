using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinosVsRobots
{
    class BattleField
    {
        public string userInput;
        public string selectCharacter;
        Fleet fleet = new Fleet();
        Herd herd = new Herd();

        public void gameController()
        {
            gameInit();
        }

        public void gameInit()
        {
            Console.WriteLine("Welcome to Robots vs. Dinosaurs, would you like to play a game? Please enter yes or no. ");
            userInput = Console.ReadLine().ToLower();
            gameOptions();
        }

        public void gameOptions()
        {
            if (userInput == "y" || userInput == "yes")
            {
                Console.WriteLine("Awesome, please enter (1) to do battle a robot or (2) kick butt as a dinosaur: ");
                selectCharacter = Console.ReadLine();
                switch (selectCharacter)
                {
                    case "1":
                        Console.WriteLine($"Excellent Choice you are a Robot!!!");
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        fleet.robotInit();
                        break;
                    case "2":
                        Console.WriteLine($"Excellent Choice you are a Dinosaur");
                        herd.dinoInit();
                        break;
                    default:
                        Console.WriteLine($"Sorry that is not option....");
                        gameOptions();
                        break;
                }
            }
            else if (userInput == "n" || userInput == "no")
            {
                Console.WriteLine("Aww that's too bad, maybe next time. BYE");
                Console.WriteLine("Press Enter to exit.");
                Console.ReadLine();
            }else
            {
                Console.WriteLine("Please enter either yes or no");
                gameInit();
            }
        }
    }
}
