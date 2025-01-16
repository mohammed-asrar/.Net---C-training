using System;
using System.Diagnostics.Eventing.Reader;

namespace Draft
{
    internal class string2switch
    {
        static void Main(string[] args)

        {
            
            Console.WriteLine(" CAD Customization Training");
            Console.WriteLine("     CAD Customization Training");
            Console.WriteLine("         CAD Customization Training");
            Console.WriteLine("             CAD Customization Training");



            //Varaiables
            String characterName = "Mohammed"; // Variables (method one)
            int characterAge;   // Variables (method two)
            characterAge = 24;


            Console.WriteLine("Im Mohammed");
            Console.WriteLine("My age is 24");
            Console.WriteLine("Im " + characterName);  // adding the varaible in the code line 
            Console.WriteLine("My age is " + characterAge); // adding the varaible in the code line
            Console.WriteLine("And Im " + characterAge + " years old"); // if we need to add the varaiable on the mid of the sentence use "+varaible+"

            characterName = "Asrar";
            Console.WriteLine(characterName); // other type of way

            string petname;        // other methodway for variable             
            petname = "Luna"; // Declaring a variable with a pet name
            Console.WriteLine($"My pet is {petname}");  // Using string interpolation $ to embed the petname variable into the string


            petname = "Shasha";
            Console.WriteLine($"My pet is {petname}"); //Same string interpolation method


            //Datatypes
            String phrase = "Cad Customization";
            double gpa = 3.0;
            int age = 30;
            bool Male = true;
            float gpa1 = 1.2f;
            byte gpa2 = 255;    // 0 to 255
            sbyte gpa3 = -128; // -128 to 127


            Console.WriteLine(phrase);
            Console.WriteLine(gpa);
            Console.WriteLine(gpa2);
            Console.WriteLine(Male);


            //Types of Casting

            //Implicit Casting
            int myInt1 = 10;          // An integer (smaller type)
            double myDouble1 = myInt1; // Automatically converted to a double (larger type) (NO DATA LOSS)


            Console.WriteLine(myInt1);    // Output: 10
            Console.WriteLine(myDouble1); // Output: 10.0


            //Explicit Casting
            double myDouble2 = 9.78;
            int myInt2 = (int)myDouble2;    // Manual casting: double to int (DATA LOSS)

            Console.WriteLine(myDouble2);   // Outputs 9.78
            Console.WriteLine(myInt2);      // Outputs 9


            //Working With Strings

            Console.WriteLine("Giraffe \nAcademy");  // By using "\n" we can use that words into next lines
            Console.WriteLine("Giraffe\"Academy\""); // By this we can add " mark in the sentence
            Console.WriteLine("Hello\n\tWorld!"); // t - write in next line
            Console.WriteLine(phrase);
            Console.WriteLine(phrase.Length); // To know the pharse information 
            Console.WriteLine(phrase.Contains("Cad")); // To identify given values is there are not
            Console.WriteLine(phrase[2]); // To spot the particural letter

            //Working With Numbers

            Console.WriteLine(50);
            Console.WriteLine(5 + 5);
            Console.WriteLine(5 - 5);
            Console.WriteLine(5 + age);
            Console.WriteLine(Math.Sqrt(age));
            Console.WriteLine(Math.Max(0, 90));
            Console.WriteLine(Math.Round(2.33));

            //Getting User Input

            Console.Write("Hello, Enter your name: ");   //Creating a prompt and getting the data from user
            string name = Console.ReadLine();
            Console.WriteLine("Welcome " + name);

            Console.Write("Enter you pasword");
            string password = Console.ReadLine();
            Console.WriteLine("Incorrect Password: " + password);

            //User Input and Numbers

            int numb = Convert.ToInt32("45"); //Method for convert String into number
            Console.WriteLine(numb + 6);

            int numb4 = int.Parse("100"); //Method for convert String into number
            Console.WriteLine(numb4 + 6);

            string myboolstring = "False";
            bool mybool = Convert.ToBoolean(myboolstring);
            Console.WriteLine("mybool is " + mybool);

            // Build a calculator
            Console.WriteLine("Enter a number");
            int numb1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number");
            int numb2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(numb1 + numb2);

            Console.WriteLine("Enter a number");
            double double3 = Convert.ToDouble(Console.ReadLine()); //Another way od calculator double - String Interpolation Method
            Console.WriteLine("Enter another number");
            double double4 = Convert.ToDouble(Console.ReadLine());
            double sum = double3 + double4;
            Console.WriteLine($"The result of: {double3} and {double4} is {sum}");

            // Implicitely typed variables   

            var myfavoriteGenre = "LiteRPGs"; //This is a string, but it's not used in the number operation.
            var myfavoriteNumber = 101;
            var myfavoriteNumber1 = 105;

            int ourNumberCombined = myfavoriteNumber + myfavoriteNumber1;
            Console.WriteLine(ourNumberCombined);

            // Operators & Order
            int result = 5 + 3 * 2;
            int resultorder = (5 + 3) * 2; // order changed by adding bracket
            Console.WriteLine($" {result} and {resultorder}");

            // String Format Method
            string formatname = "John";
            int formatage = 30;
            string formatresult = string.Format("Name: {0}, Age: {1}", formatname, formatage);
            Console.WriteLine(formatresult);


            //If Statement
            bool isRainy = true;
            bool hasumberlla = false;

            if (isRainy)
            {
                Console.WriteLine("Is it rainy"); // it will display becoz its true
            }

            if (hasumberlla)
            {
                Console.WriteLine("you have umberlla"); // it will not display becoz its false
            }




            //Operators

            //Logical Operators
            // && (AND): True if both are true.
            // || (OR): True if at least one is true.
            // ! (NOT): Flips true to false or false to true.
            // & (AND, no shortcut): Checks both conditions even if the first is false.
            // | (OR, no shortcut): Checks both conditions even if the first is true.
            // ^ (XOR): True if only one is true, but not both.


            // AND 
            bool isShopping = true;
            bool hasWallet = true;

            if (isShopping && hasWallet) // AND - && OPs output will be true becoz both are ture
            {
                Console.WriteLine("I'm done shopping");
            }

            // OR
            bool isDevelopment = true;
            bool isProduction = false;

            if (isDevelopment || isProduction) // Output will be true becoz wither one is true
            {
                Console.WriteLine("Whats your project state");
            }


            // NOT operators
            bool isWorking = false;
            bool isNotWorking = true;
            if (!isDevelopment || !isProduction) // output will be true becoz give reverse opposite value

            {
                Console.WriteLine("What about the system");
            }

            // Relational Operator < <= > >=

            int greaternum = 24;
            int lessernum = 18;

            bool isGreater = greaternum > lessernum;
            Console.WriteLine(isGreater); //Output will be true

            int partyage = 45;
            if (partyage > 18)
            {
                Console.WriteLine("Go party in the Club");  // Person is older than 18, they can go to the club
            }
            else // It checks the condition in the if statement first. If the condition is false. By using (partyage <= 18) it accept the frist code. 
                 //then the code inside the else block is executed, which says the person cannot enter the club yet.
            {
                Console.WriteLine("Come after 18"); // Person is 18 or younger, they can't go to the club yet
            }

            //Same relational method in userInput
            Console.WriteLine("How old are you ? ");
            int partyage1 = int.Parse(Console.ReadLine());

            if (partyage1 > 18)
            {
                Console.WriteLine(" Go Party in the club");

            }
            else
            {
                Console.WriteLine("Come after 18");

            }
            

            // Equality Operators

            int equalnum1 = 0;
            int equalnum2 = 0;

            bool isEqual = equalnum1 == equalnum2; // == mean LHS=RHS kind off
            bool isNotEqual = equalnum1 != equalnum2; // This code says about != mean not equal

            if (equalnum1 == int.Parse(Console.ReadLine()))
            {
                Console.WriteLine("Numbers are equal !");
            }
            else
            {
                Console.WriteLine("Try again !");
            }
            
            // Nested If Statement
            Console.WriteLine("Please Enter your age for the address");
            int addage = int.Parse(Console.ReadLine());

            if (addage >= 18)
            {
                Console.WriteLine("Please Enter your address");
                string address = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You can't process further more");
            }
            
            
            // Clubbing Method
            Console.WriteLine("How old are you?");
            int personage = int.Parse(Console.ReadLine());
            bool isWithParents = false;

            if (personage >= 18)
            {
                Console.WriteLine("You Can watch the Movie");
            }
            else if (personage >=13)
            {
                Console.WriteLine("Are you with your partents? Answer with Yes or No");
                string isWithParentsString = Console.ReadLine();
                if (isWithParentsString == "Yes")
                {
                    Console.WriteLine("You can watch the movie with your parents!");
                }
                else // Here you can see I didn't use {} bracket. For 1 line code brackets not required. But following {} good and clean look
                
                    Console.WriteLine("Sorry, you cannot watch the movie without parents.");         

            }
            else 
            {
                Console.WriteLine("No Movie come after 18 !");
            }
            int day = 7;
            string dayName;

            switch (day)
            {
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                case 7:
                    dayName = "Sunday";
                    break;
                default:
                    dayName = "Invalid day";
                    break;
            }

            Console.WriteLine(dayName);  // Output: Wednesday

            int month = 3;
            string monthname;

            switch (month) // Same 
            {
                case 1: monthname = "january";
                    break;
                case 2: monthname = "February";
                    break;
                case 3: monthname = "March";
                    break;
                default : monthname = "No Month";
                    break;
                    
                        
            }
            Console.WriteLine(monthname); // output: March


            Console.ReadLine();


        }

    }
}
