using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    internal class ConditionsandIfStatements
    {
        static void Main(string[] args)
        {
            //CONDITIONS:
            //Less than: a < b
            //Less than or equal to: a <= b
            //Equal to: a == b
            //Greater than: a > b
            //Greater than or eqal to: a >= b
            //Not equal to: a != b

            //You can use the conditions above to perform different actions for different decisions.
            //CONDITIONAL STATEMENTS
            //Use if to specify a block of code to be executed if a specified condition is true
            //Use else to specify a block of code to be executed if a specified condition is false
            //Use else if to specify a new condition to test if the first condition is false
            //Use switch to specify many alternative blocks of code to be executed

            //EXAMPLE: Test 2 values to find out if 20 is greater than 10. If the condition is true, print some text
            if (20 > 18)
            {
                Console.WriteLine("20 is greater than 18");
            }
            //EXAMPLE 2: Below, we use 2 variables, x and y, to test whether x is greater than y (using the > operator) As x is 20 and y is 18, and we know 20 is greater than 18. We print the true result to the screen
            int x = 20;
            int y = 18;
            if (x > y)
            {
                Console.WriteLine("x is greater than y");
            }

            //ELSE specifies a block of code to be executed if the condition is false
            //if (true)
            //{
            //executes if true
            //}
            //else
            //{
            //executes if false
            //}

            //EXAMPLE:
            int time = 20;
            if (time < 18)
            {
                Console.WriteLine("Good Day!");
            }
            else
            {
                Console.WriteLine("Good Night!"); //Good Night prints since the time is not less than 18 (condition is false)
            }

            //ELSE IF: used to specify a new condition if the first condition is false
            //EXAMPLE:
            int time2 = 22;
            if (time2 < 10)
            {
                Console.WriteLine("Good Morning!");
            }
            else if (time2 < 20)
            {
                Console.WriteLine("Good Day!");
            }
            else
            {
                Console.WriteLine("Good Evening!"); //Prints since both conditions above are false
            }

            //TERNARY OPERATOR: This is a shorthand if else. It consists of 3 operands and can be used to replace multiple lines of code with a single line
            //EXAMPLE
            int time3 = 20;
            string result = (time3 < 18) ? "Good Day!" : "Good Night!"; //GOOD NIGHT prints since 20 is greater than 18
                Console.WriteLine(result);

        }
    }
}
