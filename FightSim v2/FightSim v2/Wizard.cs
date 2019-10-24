using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightSim_v2
{
    class Wizard : Fighter
    {
        //En klass som är full glass-cannon. Antingen så vinner man direkt eller så förlorar man direkt.

        public Wizard()
        {
            hp = 1;

        }

        public override int Attack()
        {
            int dmg = generator.Next(100, 50000);
            return dmg;
        }

    }
}
