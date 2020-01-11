using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinosVsRobots
{
    class Dinosaur
    {
        public string dinoName;
        public int dinoHealth;
        public int dinoPowerLevel;
        public Weapon weapon;

        public Dinosaur(string dinoName, int dinoHealth, Weapon weapon)
        {
            this.dinoName = dinoName;
            this.dinoHealth = dinoHealth;
            this.weapon = weapon; 
        }

        public void dinoAttack(Robot robot)
        {
            robot.robotHealth -= weapon.weaponsAttack();
        }
    }
}
