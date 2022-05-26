using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqFoxxpy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> entiers = new List<int> {4,5,2,3,1,1,0,5,8,9,10,15,16,20,21,4,5 };

           
            var query = from n in entiers
                        where n > 2 // where = conditions
                        where n % 2 == 0 // qui sont des multiples de 2 
                        where n < 20 // inf a 20
                        where n != 8 // != = different de 8
                        orderby n descending  // = trier le resultat par ordre décroissant, on aurait aussi pu mettre ascending pr l'ordre croissant
                        select n;

            foreach(var item in query)
            {
                Console.WriteLine(item); // affichage des resultats ds la console
            }
        }
    }

}