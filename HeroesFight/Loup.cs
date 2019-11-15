using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesFight
{
    public class Loup : Monstres, ICuir
    {
        private int _cuir;
        public int Cuir
        {
             get{ return _cuir; }
             set{ _cuir = value; } 
        }

        public Loup()
        {
            this.Cuir = De2.Lancer();
        }
    }
}
