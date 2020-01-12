using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinosVsRobots
{
    class Weapon
    {
        public string weaponName;
        public int attackPower;

        public Weapon(string weaponName)
        { 
            this.weaponName = weaponName;
        }
        public int weaponsAttack()
        {
            
             Random randNum = new Random();
             attackPower = randNum.Next(10, 20);

             return attackPower;  
            
        } 
    }
}
