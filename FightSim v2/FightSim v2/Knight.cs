using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightSim_v2
{
    class Knight : Fighter
    {
        //En klass med högre hp men mindre evasion så att den tar mer slag men även tål mer slag

        public Knight()
        {
            hp = 200;
            evasivness = -20;

        }

    }
}
