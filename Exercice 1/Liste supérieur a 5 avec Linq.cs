using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqFoxxpy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> entiers = new List<int> {4,5,2,3,1,1,0,5,8,9,10,15,16,20,21,4,5 }; // Pour pouvoir utiliser la fonction List en c# il faut utiliser l'espace de nom System.collections.generic (voir plus haut)

            var query = from n in entiers // On utilise "query" qui relie au system.linq. De la liste "Entiers" on va recupérer a chaque fois "n".
                        where n > 5 // Ici est la condition , donc on récupere tous les "n", donc tout les entiers, supérieurs a 5 
                        select n; // on récupere n
            
            foreach(int element in query) // On rajoute la fonction foreach car on a besoin de parcourir les iterators pour en afficher les resultats, et sans ce foreach on obtiendrait juste qql chose ressemblant à : "System.linq.Enumerable+WhereListIterator"
            { 
                Console.WriteLine(element); 
            }

 
            
       
       }
    }
}
// plus qu'a compiler 