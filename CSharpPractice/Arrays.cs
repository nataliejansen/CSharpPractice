using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    internal class Arrays
    {
        static void Main(string[] args)
        {
            //ARRAYS! used to store multiple values in a single variable instead of declaring seperate variables for each value.
            //To declare an array, define the variable type with []
            //string[] cars;
            //To insert values into an array, we use an ARRAY LITERAL: Place the values in a comma seperated list using {}
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            //Access the elements of the array by referring to the index number(starts with 0)
            Console.WriteLine(cars[0]);
            //Changing an array element: refer to the index number
            cars[0] = "Honda";
            Console.WriteLine(cars[0]); //This now outputs Honda instead of Volvo
            //Array Length: to find out how many elements an array has, use the Length property
            Console.WriteLine(cars.Length);

            //Loop through an array: You can loop through the array elements with a for loop and use the Length property to specify how many times a loop should run
            //EXAMPLE: Below outputs all elements in the array
            for (int i = 0; i < cars.Length; i++) 
            {
                Console.WriteLine(cars[i]);
            }

            //Outputs all elements using a foreach loop
            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }

            //Foreach is easier to read, write, and does not require a counter!

            //Sort an Array: There are many methods available, for example, Sort(), which sorts an array alphabetically or in an ascending order
            //Example: Sort below
            int[] myNumbers = { 5, 1, 8, 9 };
            Array.Sort(myNumbers);
            foreach (int i in myNumbers)
            {
                Console.WriteLine(i);
            }

            //The System.Linq Namespace offers other useful array menthods. See below for examples
            Console.WriteLine(myNumbers.Max()); //returns the largest value
            Console.WriteLine(myNumbers.Min()); //returns the smallest value
            Console.WriteLine(myNumbers.Sum()); //returns the sum of elements

            //Multidimentional Arrays: If you want to store data as a tabular form(like a table with rows and columns) you would use a multidimentional array. This is basically an array of arrays. Arrays can have any number of dimensions. The most common are two-dimensional arrays(2D)
            //To create a 2D array, add each array with its own set of curly braces, and insert a comma (,) inside the square brackets:
            int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } }; //The single [,] specifies that the array is two-dimensional. A three-dimensional array would have two commas [,,]
            //numbers is now an array with two arrays as its ellements. The first array element contains three elements: 1, 4, and 2, while the second array element contains 3, 6, and 8. We would think of the array as a table with rows and columns

            //      COLUMN0 | COLUMN1 | COLUMN2
            // ROW0   1      4      2
            // ROW1   3      6      8

            //Access the Elements of a 2D Array: You must specify two indexes: one for the array, and one for the element inside that array.
            //(One for the row and one for the column)

            //The statement below accesses the value of the element in the first row (0) and the third column (2) of the numbers array:
            Console.WriteLine(numbers[0, 2]);

            //Change the Elements of a 2D Array
            //The following example will change the value of the element in the first row (0) and fist column (0)
            numbers[0, 0] = 5;
            Console.WriteLine(numbers[0,0]); //This will now output 5 instead of 1

            //Loop through an 2D Array
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            //If we were to use a for loop for the example above, we would have to use GetLength() to specify how many times the loop should run
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.WriteLine(numbers[i, j]);
                }
            }

            Console.WriteLine("ARRAY PRACTICE:\n");
            //ARRAY PRACTICE:

            //DECLARE AND THEN REVERSE THE FOLLOWING NUMBERS IN AN ARRAY: 1, 4, 3, 2

            int[] arr = { 1, 4, 3, 2 };
            foreach (int j in arr)
            {
                Console.WriteLine(j);
            }

            Array.Reverse(arr);
            foreach (int i in arr)
            {
               Console.WriteLine(i);
            }



            //RETURN THE SUM OF ALL POSITIVE NUMBERS: 1, -4, 7, 12 (THIS SHOULD OUTPUT 20)
            Console.WriteLine("SUM OF ALL POSITIVE NUMBERS:");

            int[] array = { 1, -4, 7, 12 };
            int sum = 0;
            for (int k = 0; k < array.Length; k++)
            {
                if (array[k] > 0)
                {
                    sum += array[k];
                }
            }
            Console.WriteLine(sum);





            




        }
    }
}
