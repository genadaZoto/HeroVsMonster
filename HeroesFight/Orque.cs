using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesFight
{
    public class Orque: Monstres,  IOr
    {
        private int _or;
       
        public int Or
        {
            get { return _or; }
            set { _or = value; }
        }

        protected override int Force
        {
            get { return  base.Force + 1; }
        }

        public Orque()
        {
            this.Or = De1.Lancer();
        }

    }
}
