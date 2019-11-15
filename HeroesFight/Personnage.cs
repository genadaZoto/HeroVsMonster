using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesFight
{
    public abstract class Personnage
    {
        private int _endurance;
        private int _force;
        private int _pv;
        private De de1= new De(6);
        private De de2 = new De(4);
        public event Action<Personnage> LaMort;

       

        protected virtual int Endurance
        {
            get { return _endurance; }
            private set { _endurance = value; }
        }

        protected virtual int Force
        {
            get { return _force; }
            private set { _force = value; }
        }

        private int PV
        {
             get { return _pv; }
             set
             {
                if (value <= 0)
                {
                    LaMort(this);
                    _pv = 0;
                }
                else
                _pv = value; }
        }

        public int PointVie()
        {
            
            return this.PV;
        }
        public De De1
        {
            get { return de1; }
            set { de1 = value; }
        }
        public De De2
        {
            get { return de1; }
            set { de1 = value; }
        }

        protected Personnage()
        {
            Reset();

        }

        protected void Reset()
        {
            this.Force = De.CalculStat();
            this.Endurance = De.CalculStat();
            this.PV = Endurance + Modificateur(Endurance);
        }
        public void Frappe(Personnage victime)
        {
           int degat= (de2.Lancer())+ Modificateur(Force);
           victime.PV -= degat;
           Console.WriteLine($" {this.GetType().Name} a frappé le {victime.GetType().Name} et lui a enlevé {degat}.");
            
        }

        public int Modificateur(int score)
        {
            //merci Cerise
            return ((score < 5) ? -1 : (score < 10) ? 0 : (score < 15) ? 1 : 2); 
        }
    }

}
