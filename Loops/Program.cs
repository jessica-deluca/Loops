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

            //// count from 50 to 100
            //for (int i = 50; i <= 100; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //string greeting = "My name is Little Bill.";
            //// The .Split() method takes a string and turns it into an array of smaller strings (substrings). It defaults the split on spaces.
            //string[] wordsInGreeting = greeting.Split(); // splits greeting by spaces

            //for (int i = 0; i < wordsInGreeting.Length; i++)
            //{
            //    Console.WriteLine(wordsInGreeting[i]);
            //}

            //// Create an array called days with the elements Monday, Tuesday and Wednesday.
            //string[] days = { "Monday", "Tuesday", "Wednesday" };
            //// Using a For Loop, print the elements of the days array.
            //for (int i = 0; i < days.Length; i++)
            //{
            //    Console.WriteLine(days[i]);
            //}

            //// Start with the string "Once upon a time" and create an array called storyWords using the Split method.
            //string story = "Once upon a time";
            //string[] storyWords = story.Split();

            // Reserve the order of the elements in the array and using a For Loop, print each word.
            // Array.Reverse(storyWords);
            //for (int i = 0; i < storyWords.Length; i++)
            //{
            //    Console.WriteLine(storyWords[i]);
            //}

            //// Add the product (multiplication) of 1 through 10 (including 10) using a For Loop (1*2 = result * 3); print the product to the screen

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int product = numbers[0];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    product = product * numbers[1];
            //}
            //Console.WriteLine(product);

            //int product = 1;
            //for(int i = 1; i <=10; i++)
            //{
            //    product = product * i;
            //}
            //Console.WriteLine(product);


        }
    }
}
