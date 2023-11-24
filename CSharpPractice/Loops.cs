using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    internal class Loops
    {
        static void Main(string[] args)
        {
            //LOOPS can execute a block of code as long as a specific condition is reached
            //WHY?: Save time, reduce errors, and make code more readable

            //WHILE LOOPS
            //Loops through a block of code as long as the specified condition is TRUE
            //while (true)
            //{
            //    //Code to be executed
            //}
            //EXAMPLE: Below, the code in the loop will run infinitely as long as variable (i) is less than 5
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++; 
            }

            //DO WHILE LOOPS
            //is a variant of the while loop. The loop will execute the code block once, before checking if the condition is true, then it will repeat the loop as long as the condition is true
            //do
            //{
            //    //Code to be executed
            //} while (true);

            //EXAMPLE:
            int i2 = 0;
            do
            {
                Console.WriteLine(i2);
                i2++; //Don't forget to increase the variable used in the condition, otherwise the loop never ends!
            } while (i2 < 5);

            //FOR LOOPS
            //This is used when you know exactly how many times you want to loop through a block of code. Use for instead of while
            //for (int i = 0; i < length; i++)
            //{
            //Code to be executed
            //}

            //EXAMPLE: Below prints the numbers 0-4
            for (int i3 = 0; //Sets a variable before the loop starts
                i < 5; //Defines the conditikon for the loop to run. If the condition is true, the loop starts over again. If the condition is false, the loop ends
                i3++) //Increases the value each time the code block in the loop has been executed
            {
                Console.WriteLine(i3);
            }

            //ANOTHER EXAMPLE: This will only print even values between 0 and 10
            for (int i4 = 0; i4 <= 10; i4 = i4 + 2)
            {
                Console.WriteLine(i4);
            }

            //NESTED LOOP: it is possible to place a loop inside of another loop. The "inner loop" will be executed on time for each iteration of the "outer loop".
            //EXAMPLE:
            //Outer loop
            for (int i5 = 1; i5 <=2; i5++)
            {
                Console.WriteLine("Outer: " + i5);
                //Inner loop
                for (int j5 = 1; j5 <= 3; j5++)
                {
                    Console.WriteLine("Inner: " + j5);
                }
            }

            ////FOREACH LOOP is used exclusively to loop through an array
            //foreach (var item in collection)
            //{
            //    //code block to be executed
            //}
            //EXAMPLE: Output all the elements in the cars array
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string i6 in cars)
            {
                Console.WriteLine(i6);
            }

        }
    }
}
