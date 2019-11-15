using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesFight
{
    class Program
    {
        static void Main(string[] args)
        {
            De de = new De(6);

            //Console.WriteLine(de.Lancer());
            //Console.WriteLine(De.CalculStat());

       
         
            Foret foret = new Foret();

            Console.WriteLine("Bienvenue dans la Foret!\nQuel hero vous voulez?");
            string hero = Console.ReadLine();

            if(hero== "h")
            {
                Console.WriteLine("Votre Hero sera un Humain est il va se battre contre 3 monstres!");
                foret.Hero= new Humain();
                foret.Play();
            }
            else
            {
                Console.WriteLine("Votre Hero sera un Nain est il va se battre contre 3 monstres!");
                foret.Hero = new Nain();
                foret.Play();
            }

            
            


            Console.ReadLine();
        }
    }
}
