using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesFight
{
    public class Foret
    {
        private Hero _hero;
        private Monstres _monstre;
        private bool _gameover;

        public Hero Hero
        {
            get { return _hero; }
            set { _hero = value; }
        }

        public Monstres Monstre
        {
            get { return _monstre; }
            set { _monstre = value; }
        }

        public bool GameOver
        {
            get { return _gameover; }
            set { _gameover = value; }
        }

        public Foret()
        {
            //this.Hero = new Humain();
            //this.Hero = new Nain();
           // Hero.LaMort += LaMortAction;
            this.Monstre = GenerateurMonstre();
           
        }

        public Monstres GenerateurMonstre()
        {
            De de = new De(3);
            int m = de.Lancer();
            Monstres mo = (m == 1) ? new Loup() : ((m == 2) ? (Monstres)new Orque() : new Dragon());
            mo.LaMort += LaMortAction;
            return mo;
        }

       
        public void LaMortAction(Personnage P)
        {
            if (P is Hero)
            {
                GameOver = true;
            }
            else
            {
                Hero.Repos();
                Hero.Depouiller((Monstres)P);
                Monstre = GenerateurMonstre();
                Console.WriteLine($" {Hero.GetType().Name} a gangné contre le {((Monstres)P).GetType().Name},  ses point de vie sont {Hero.PointVie()} et il a dépouiller {Hero.Or} or, {Hero.Cuir} cuir.");
            }
        }


        public void Play()
        {
            Hero.LaMort += LaMortAction;
            do
            {
                Console.WriteLine();
                Console.WriteLine($"PV {this.Monstre.GetType().Name}  {this.Monstre.PointVie()} | PV {this.Hero.GetType().Name} {Hero.PointVie()}  ");
                
                Hero.Frappe(Monstre);
                Monstre.Frappe(Hero);
                

            }while(GameOver == false);

            int mpv = this.Monstre.PointVie();
            int hpv = this.Hero.PointVie();

            if (hpv > mpv)
            {
                Console.WriteLine($" {Hero.GetType().Name} a gangné contre le {Monstre.GetType().Name},  ses point de vie sont {Hero.PointVie()} et il a dépouiller {Hero.Or} or, {Hero.Cuir} cuir.");
            }
            else
            {
                Console.WriteLine($" {Monstre.GetType().Name}  a gangné contre  le {Hero.GetType().Name}, ses point de vie sont {Monstre.PointVie()}.");
            }
        }


    }
}
