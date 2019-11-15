using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesFight
{
    public class De
    {
        private static Random random=new Random();
       
        private int _max;

        public static Random  Random
        {
            get { return random; }
            set { random = value; }
        }
        public int Min
        {
            get { return 1; }
          
        }

        public int Max
        {
            get { return _max; }
            private set { _max = value; }
        }

        public De( int nbFaces)
        {
           
            this.Max = nbFaces;
        }
          
        public int Lancer()
        {
            return(Random.Next(Min, Max+1));  
            ////Max +1 pq la derniere valeur n'est pas comprise et on veux pas modifier les faces du random
        }

        public static int CalculStat()
        {
            De de = new De(6);
            int resultat = 0;
           
            List<int> myList = new List<int>();
            for (int i = 0; i < 4; i++)
            {
                myList.Add(de.Lancer());
            }

            myList.Sort();
            //for (int i = 0; i < myList.Count; i++)
            //{
            //    for (int j = 0; j < myList.Count; j++)
            //    {
            //        if (myList[i] > myList[j])
            //        {
            //            int temp = myList[i];
            //            myList[i] = myList[j];
            //            myList[j] = myList[i];
            //        }
            //    }
            //}

            for (int i = 1; i < myList.Count; i++)
            {
                resultat += myList[i];
            }
            return resultat;

        }



    }
}
