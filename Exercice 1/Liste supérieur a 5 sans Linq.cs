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

            foreach(int n in entiers) // Premier manière de voir les entiers supérieurs à 5 mais sans utiliser Linq
            {
                if (n > 5)
                {
                    Console.WriteLine(n); // affichage du résultats
                }
            }
       
       }
    }
}