using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightSim_v2
{
    class Fighter
    {
        //Nödvändiga variablar
        protected int hp = 100;
        protected int evasivness = 0;
        protected int armor = 0;
        public string name;
        //En random generator för att slumpa tal
        protected Random generator = new Random();

        //En metod som slumpar ett attack värde mellan 1 och 20, sedan returneras detta värde som en int
        public virtual int Attack()
        {
            int dmg = generator.Next(1, 21);
            return dmg;
        }

        //En metod som skadar Fightern, denna tar emot en int som parameter
        public void Hurt(int amount)
        {
            
                hp -= amount - armor;


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

        public bool Hit()
        {
            int hit = generator.Next(1, 101) - evasivness;

            if (hit >= 30)
            {
                return true;

            }
            else
            {

                return false;

            }

        }

    }
}
