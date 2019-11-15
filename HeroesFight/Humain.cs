using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesFight
{
    public class Humain : Hero
    {
        //private int _endurance;
        //private int _force;

        protected override int Endurance
        {
            get { return base.Endurance + 1; }
        }

        protected override int Force
        {
            get { return base.Force + 1; }
        }
    }
}
