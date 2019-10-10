using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightSim_v1
{
    class Fighter
    {
        //Nödvändiga variablar
        private int hp = 100;
        public string name;
        //En random generator för att slumpa tal
        Random generator = new Random();

        //En metod som slumpar ett attack värde mellan 1 och 20, sedan returneras detta värde som en int
        public int Attack()
        {
            int dmg = generator.Next(1, 21);
            return dmg;
        }

        //En metod som skadar Fightern, denna tar emot en int som parameter
        public void Hurt(int amount)
        {
            hp -= amount;

        }

        //En metod som håller koll på om Fightern är vid liv eller inte, returnerar true/false
        public bool IsAlive()
        {
            if (hp > 0)
            {
                return true;

            }
            else
            {
                return false;

            }

        }

        //Returnerar värdet på HP så den privata int:en kan visas i main
        public int GetHp()
        {
            return hp;

        }

    }
}
