using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqFoxxpy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> fruits = new List<string> { "Banane", "Ananas", "Cerise", "Framboise", "Groseilles", "Pomme",
            "Poire", "Tomate", "Kiwi", "Raisin", "Mangue", "Datte"};

            var query  = from f in fruits
                         where f.ToUpper()[0] == 'P' // ToUpper permets de mettre tte la chaine de caractère en majuscule pour être sur de ne pas se tromper
                         where f.Length > 4 // Longueur > a 4 
                         where f.Contains('o') // Tt les mots contenant un o
                         where !f.Contains('m') // Mais !f est l'inverse, donc sans m
                         select f;

        
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }

        }
    }

}