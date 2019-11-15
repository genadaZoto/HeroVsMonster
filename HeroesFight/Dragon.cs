using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesFight
{
    public class Dragon: Monstres, ICuir, IOr
    {
        private int _cuir;
        private int _or;
        

        public int Cuir
        {
            get { return _cuir; }
            set { _cuir = value; }
        }

        public int Or
        {
            get { return _or; }
            set { _or = value; }
        }

        protected override int Endurance
        {
            get { return base.Endurance + 1; }
        }
        public Dragon()
        {
            this.Cuir = De2.Lancer();
            this.Or = De1.Lancer();
        }
    }
}
