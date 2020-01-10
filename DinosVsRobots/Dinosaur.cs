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
        public string dinoAttack;

        public Dinosaur(string dinoName, int dinoHealth, string dinoAttack)
        {
            this.dinoName = dinoName;
            this.dinoHealth = dinoHealth;
            this.dinoAttack = dinoAttack;
            
        }
    }
}
