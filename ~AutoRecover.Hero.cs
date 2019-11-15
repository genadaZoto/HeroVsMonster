using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesFight
{
    public abstract class Hero: Personnage
    {
        private int _or;
        private int _cuir;

        protected int Or
        {
            get{return _or;}
            set{_or = value; }
        }

        protected int Cuir
        {
            get { return _cuir; }
            set { _cuir = value; }
        }

        protected Hero(int or, int cuir)
        {
            this.Or = or;
            this.Cuir = cuir;
        }

        protected void Repos(Personnage joueur)
        {

        }
    }
}
