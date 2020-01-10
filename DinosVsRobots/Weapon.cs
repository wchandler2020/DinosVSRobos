using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinosVsRobots
{
    class Weapon
    {
        public string weaponType;
        public int attackPower;

        public Weapon(string weaponType)
        { 
            this.weaponType = weaponType;
            weaponsInit();
        }
        public void weaponsInit()
        {
            if(weaponType == "plasma gun")
            {
                PlasmaSwordAttack();
            }else if(weaponType == "laser")
            {
                LaserAttack();
            }else if(weaponType == "shotgun")
            {
                ShotGunAttack();
            }
            else
            {
                //add user validation
            }  
        }

       public void PlasmaSwordAttack()
        {
            Random randNum = new Random();
            attackPower = randNum.Next(1, 10);
            
        }

        public void LaserAttack()
        {
            Random randNum = new Random();
            attackPower = randNum.Next(1, 10);
        }

        public void ShotGunAttack()
        {
            Random randNum = new Random();
            attackPower = randNum.Next(1, 10);
        }
    }
}
