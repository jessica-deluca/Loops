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

            //// another way to do the problem above:
            //string story = "Once upon a time";
            //string[] storyWords = story.Split();

            //for (int i = storyWords.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(storyWords[i]);
            //}

            //// Add the product (multiplication) of 1 through 10 (including 10) using a For Loop (1*2 = result * 3); print the product to the screen

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int product = numbers[0];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    product = product * numbers[i];
            //}
            //Console.WriteLine(product);

            //int product = 1;
            //for (int i = 1; i <= 10; i++)
            //{
            //    product = product * i;
            //}
            //Console.WriteLine(product);

            // Foreach loop - used to iterate over a collection (ex. list or array)
            // You can think of the structure of a foreach loop as the statement;
            // For each item in the collection, do something

            // foreach(dataType variable in a collection)
            // { 
            //      do something
            // }

            //string[] firstMonths = { "Jan", "Feb", "Mar", "April", "May", "Jun" };
            //always start with the key word: foreach
            // foreach loops allow the temporary variable to "know" to assign itself to each element in the collection (like an array), one at a time
            // foreach runs beginning to end; for loop you give it a stopping point
            // foreach (string month in firstMonths)
            //    {
            //        Console.WriteLine(month);
            //    }

            // Create an array of 6 musicians (bands or solo artists)
            // Using a foreach loop, print each musician's name

            //string[] musicians = { "Carrie Underwood", "Kenny Chesney", "Daruis Rucker", "Tim McGraw", "Brooks & Dunn", "Rascal Flatts" };
            //foreach(string musician in musicians)
            //{
            //    Console.WriteLine(musician);
            //}

            //Console.WriteLine("What is your first name?");
            //string firsName = Console.ReadLine();
            //while(firsName.ToUpper() == "JESSICA")
            //{
            //    Console.WriteLine("Dude, you are amazing.");
            //    break; // takes you out of the loop
            //}

            //Console.WriteLine("Do you want to play the game? YES/NO");
            //string playAgain = Console.ReadLine().ToUpper();
            //while (playAgain == "YES")
            //{
            //    Console.WriteLine("It's a rematch!");
            //    Console.WriteLine("Do you want to play again? YES/NO");
            //    playAgain = Console.ReadLine();
            //}

            // Do-While loop is similar to a While loop.
            // However, a Do-While loop is used when you want a chunk of code to run at least once, but repeat only if the While condition is met
            // The structure of a Do-While loop:
            // do
            // {
            //     do something
            // }
            // while (condition);

            //string playAgain;
            //do
            //{
            //    Console.WriteLine("Welcome to my game!");
            //    // pretend the code for the game is here
            //    Console.WriteLine("Great game!!");
            //    Console.WriteLine("Do you want to play again? YES/NO");
            //    playAgain = Console.ReadLine();
            //}
            //while (playAgain == "YES");

            // Ask the user for the class (in school) that they would like to add to their GPA calculation.
            // Ask the user for the letter grade for the class (no + or -).
            // Ask the user if they have another class that they would like to add to their GPA calculation.
            // Using a Do-While loop, repeat the code if the user says "YES."

            //string answer;
            //string classes;
            //string grade;
            //Console.WriteLine("Do you want to add a class?");
            //answer = Console.ReadLine().ToLower();
            //if (answer == "yes")
            //{
            //    do
            //    {
            //        Console.WriteLine("What class would you like to add?");
            //        classes = Console.ReadLine();
            //        Console.WriteLine("Enter the letter grade for the class.");
            //        grade = Console.ReadLine();
            //        Console.WriteLine("Do you want to enter another class?");
            //        answer = Console.ReadLine().ToLower();
            //    }
            //    while (answer == "yes");
            //}


            // Nested Loop - a loop inside of another loop; the inner loop is executed more times than the outer loop
            // Real life example is a clock

            // Create a nested loop struction that prints:
            // 1234
            // 1234

            //for(int rows = 1; rows <= 2; rows++) // specifying only two rows
            //{
            //    for(int columns = 1; columns <= 4; columns++) // showing what to write in each row, then move up; more columns than rows, so make it the inner loop
            //    {
            //        Console.Write(columns);
            //    }
            //    Console.WriteLine();
            //}

            // Print a Triangle
            // Outer loop will go line by line
            // The inner loop will go over different elements in the line.
            // Result:
            // 1
            // 1 2
            // 1 2 3
            // 1 2 3 4

            //for (int rows = 1; rows <= 4; rows++)
            //{
            //    for (int columns = 1; columns <= rows; columns++)
            //    {
            //        Console.Write(columns + " ");
            //    }
            //    Console.WriteLine();
            //}

            ////Remember that in FizzBuzz, if it is not a FizzBuzz, Fizz, or Buzz number, you print the number itself.
            //Console.WriteLine("Let's Play FizzBuzz!");
            //Console.WriteLine("Please enter your FIZZ number");
            //int fizz = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please enter your BUZZ number");
            //int buzz = int.Parse(Console.ReadLine());
            //Console.WriteLine("What number would you like me to count to? (Pick a high one)");
            //int endNumber = int.Parse(Console.ReadLine());
            //for (int i = 0; i <= endNumber; i++)
            //{
            //    if (i % fizz == 0 && i % buzz == 0)
            //    {
            //        Console.WriteLine("Fizz Buzz!");
            //    }
            //    else if (i % fizz == 0)
            //    {
            //        Console.WriteLine("Fizz!");
            //    }
            //    else if (i % buzz == 0)
            //    {
            //        Console.WriteLine("Buzz!");
            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
            //    }
            //}



        }
    }
}
