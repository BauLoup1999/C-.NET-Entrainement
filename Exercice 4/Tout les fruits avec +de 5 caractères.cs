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

            var query = from f in fruits
                         where f.Length > 5 // F.length = attribut qui renvoie à la longueur de la chaine de caractere donc, tt les mots avec + de 5 caracteres
                        orderby f // trier par ordre alphabétique 
                         select f;

        
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }

        }
    }

}