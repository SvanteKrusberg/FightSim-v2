using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightSim_v2
{
    class Ranger : Fighter
    {
        //En klass som har mindre hp men betydligt bättre evasion, alltså att den kommer att ta skada färre av gångerna

        public Ranger()
        {
            hp = 50;
            evasivness = 50;

        }


    }
}
