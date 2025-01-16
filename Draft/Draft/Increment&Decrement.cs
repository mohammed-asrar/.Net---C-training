using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draft
{
    internal class Incrementing
    {
        static void Main (string[] args)
        {
            /* 
     Topics Covered:

     1. Increment and Decrement Operators: 
        - The increment (++) and decrement (--) operators increase or decrease the value of a variable by 1, respectively.

     2. Increment and Decrement in Other Methods:
        - These operators can be used in different methods to modify variable values in various contexts (e.g., loops or conditionals).

     3. Modulo Operator (%): 
        - The modulo operator returns the remainder of a division operation. For example, 7 % 3 results in 1 (remainder of 7 divided by 3).

     4. TryParse Method: 
        - `TryParse` is used to safely convert a string to a number type (like `int`). It returns `true` if the conversion is successful, and `false` if it fails, avoiding exceptions.
   */



            // Increment and Decrementing 
            int num = 0;
            Console.WriteLine($"my num is {num}");  // output is 0


            num++;
            Console.WriteLine($"my num is {num++}"); //output is 1

            num++;
            Console.WriteLine($"my num is {num++}"); // output is 3

            ++num;
            Console.WriteLine($"my num is {++num}"); //output is 6

            --num;
            Console.WriteLine($"my num is {--num}"); //output is 4

            int num1 = 5;

            Console.WriteLine("Post-Increment:");
            Console.WriteLine(num1++);  // Prints 5, then num becomes 6
            Console.WriteLine(num1);    // Prints 6

            Console.WriteLine("\nPre-Increment:");
            num1 = 5;  // Reset num to 5
            Console.WriteLine(++num1);  // num becomes 6, then prints 6
            Console.WriteLine(num1);    // Prints 6

            // Same Increment and Decrement in different method
            int num4 = 0;    // Start with num = 0

            Console.WriteLine(num4); // Output: 0

            num4++;           // Increment num by 1, so num becomes 1
            num4 += 30;       // Add 30 to num, so num becomes 31
            Console.WriteLine(num4); // Output: 31

            num4 -= 10;       // Subtract 10 from num, so num becomes 21
            Console.WriteLine(num4); // Output: 21
            // For other operaators too *=,/= with work......  


            //Modulo Operators
            int result = 10 % 3;
            Console.WriteLine(result); // Output: 1

            int result1 = 20 % 4;
            Console.WriteLine(result1); // Output: 0

            //Trypharse
            Console.WriteLine("Give me a number");
            string inputnum = Console.ReadLine();

            int num5;

            bool isnumber = int.TryParse(inputnum, out num5);

            if (isnumber)
            {
                Console.WriteLine("Well Done Bro");
            }
            else
            {
                Console.WriteLine("Try again Broo");
            }

            Console.WriteLine($"You entered num is {num5}");


            Console.ReadLine();
        }
    }
}
