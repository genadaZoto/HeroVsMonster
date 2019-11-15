using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesFight
{
    public class Nain: Hero
    {
       

        protected override int Endurance
        {
            get { return base.Endurance + 2; }
        }
    }
}
