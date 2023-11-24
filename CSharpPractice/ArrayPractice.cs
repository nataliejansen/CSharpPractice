using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    internal class ArrayPractice
    {
        static void Main(string[] args)
        {
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
