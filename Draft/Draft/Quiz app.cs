using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draft
{
    internal class Quiz_app
    {
        static void Main (string[] args)
        {
            string question1 = "What is India's national bird?";
            string answer1 = "Peacock";

            string question2 = "Who is the Father of our Nation";
            string answer2 = "Gandhi";

            string question3 = "What is the sum of 5+5 ?";
            string answer3 = "10";

            int Score = 0;

            Console.WriteLine (question1);
            string useranswer1 = Console.ReadLine ();

            if(useranswer1.Trim().ToLower() == answer1.ToLower()) //By using the trim method, it will trim out the space on the begining and end..To lower consider that i put in lower case too

            {
                Console.WriteLine("Correct");
                Score = Score + 1;

            }
            else
            {
                Console.WriteLine ($"Wrong, the correct answer is: {answer1}") ;

            }

            Console.WriteLine(question2);
            string useranswer2 = Console.ReadLine();

            if (useranswer2 == answer2)
            {
                Console.WriteLine("Correct");
                Score = Score + 1;

            }
            else
            {
                Console.WriteLine($"Wrong, the correct answer is: {answer2}");

            }

            Console.WriteLine(question3);
            string useranswer3 = Console.ReadLine();

            if (useranswer3 == answer3)
            {
                Console.WriteLine("Correct");
                Score = Score + 1;

            }
            else
            {
                Console.WriteLine($"Wrong, the correct answer is: {answer3}");

            }

            Console.WriteLine($"Quiz Completed ! Here your final score: {Score}/3");
            if (Score == 3)
            {
                Console.WriteLine("Good Job");
            }
            else if (Score > 0)
            {
                Console.WriteLine("Keep Learning");
            }
            else
            {
                Console.WriteLine("Try Again");
            }

            Console.ReadLine ();

        }
        
    }

}
