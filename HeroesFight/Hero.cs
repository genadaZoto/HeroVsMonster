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

        public int Or
        {
            get{return _or;}
            set{_or = value; }
        }

        public int Cuir
        {
            get { return _cuir; }
            set { _cuir = value; }
        }

        //protected Hero(int or, int cuir):base()
        //{
        //    this.Or = or;
        //    this.Cuir = cuir;
        //}

        public void Repos()
        {
            Reset();
        }

        public void Depouiller(Monstres victime)
        {
            if (victime is Loup)
            {
                this.Cuir = ((Loup)victime).Cuir;
            }
            if (victime is Orque)
            {
                this.Or = ((Orque)victime).Or;
            }
            if (victime is Dragon)
            {
                Dragon d = new Dragon();
                this.Or = ((Dragon)victime).Or;
                this.Cuir = ((Dragon)victime).Cuir;
            }

            //if(victime is ICuir)
            //{
            //    this.Cuir = ((ICuir)victime).Cuir;
            //}
            //if (victime is IOr)
            //{
            //    this.Cuir = ((IOr)victime).Or;
            //}

        }
    }
}
