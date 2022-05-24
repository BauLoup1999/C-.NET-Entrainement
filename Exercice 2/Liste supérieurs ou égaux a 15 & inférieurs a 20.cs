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

            var query = from n in entiers  // on utilise Var car on ne sait pas tjr de quel type seront les variables
                        where n >= 15 
                        where n < 20
                        select n;

            foreach(var item in query)
            {
                Console.WriteLine(item)
            }

        }
    }

}