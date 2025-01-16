using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draft
{
    internal class RandomNumberGenerator
    {
       static void Main (string[] args)
        {
            // creating an instance of the Random Class
            Random random = new Random();
            // this will give us a random number between 1 to 5. Number 6 will not consider
            int randomnumber = random.Next(1, 6);
            Console.WriteLine("Guess randomnumber");

            string inputstring = Console.ReadLine();
            int num;

            bool isnumber = int.TryParse(inputstring, out num);

            if (num == randomnumber)
            {
             Console.WriteLine("Correct");
              
            }
            else
            {
                Console.WriteLine("Try agin");
            }
            Console.ReadLine();

        }
       
    }
}
