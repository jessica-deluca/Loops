using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            // Nested loops
            // Infinite loops
            // Keywords break and continue

            // For loop - can be used for both counting & iterating (or in other words, go to next one) through an array (or other collection type)

            // for(initializer; condition; updater)
            // {
            //      do something
            //  }

            //for (int i = 15; i > 0; i--) // running i++ instead of i-- would be an infinite loop // people usually use i or counter
            //{
            //    Console.WriteLine(i);
            //}

            // counts from 50 to 100

            for (int i = 50; i <= 100; i++)
            {
                Console.WriteLine(i);
            }




        }
    }
}
