using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace Assignment_5_fr_ts_time
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Part3();
            //Maxym F
        }
        public static void Part1()
        {
            //Planet Boxing

            string planet;
            double weight;




            Console.WriteLine("How much do you weigh?");
            Double.TryParse(Console.ReadLine(), out weight);



            Console.WriteLine("So, which of the following planets do you want to box on?");
            Console.WriteLine("  1. Venus 2. Mars 3. Jupiter");
            Console.WriteLine("  4. Saturn 5. Uranus 6. Neptune");

            Console.WriteLine("Which planet will you be visiting (Please start with an uppercase)?");
            planet = Console.ReadLine();

            if (planet == "Venus" || planet == "1")
            {
                Console.WriteLine("Your weight on Venus will be " + weight * 0.78 + "lbs.");
            }
            if (planet == "venus")
            {
                Console.WriteLine("Your weight on Venus will be " + weight * 0.78 + "lbs.");
            }




            if (planet == "Mars" || planet == "2")
            {
                Console.WriteLine("Your weigh on Mars will be " + weight * 0.39 + "lbs.");

            }
            if (planet == "mars")
            {
                Console.WriteLine("Your weigh on Mars will be " + weight * 0.39 + "lbs.");

            }



            if (planet == "Jupiter" || planet == "3")
            {
                Console.WriteLine("Your weight on Jupiter will be " + weight * 2.65 + "lbs.");
            }
            if (planet == "jupiter")
            {
                Console.WriteLine("Your weight on Jupiter will be " + weight * 2.65 + "lbs.");
            }


            if (planet == "Saturn" || planet == "4")
            {
                Console.WriteLine("Your weight on Saturn will be " + weight * 1.17 + "lbs.");
            }
            if (planet == "saturn")
            {
                Console.WriteLine("Your weight on Saturn will be " + weight * 1.17 + "lbs.");
            }


            if (planet == "Uranus" || planet == "5")
            {
                Console.WriteLine("Your weight on Uranus will be " + weight * 1.05 + "lbs.");
            }
            if (planet == "uranus")
            {
                Console.WriteLine("Your weight on Uranus will be " + weight * 1.05 + "lbs.");
            }


            if (planet == "Neptune" || planet == "6")
            {
                Console.WriteLine("Your weight on Neptune will be " + weight * 1.23 + "lbs.");
            }
            if (planet == "neptune")
            {
                Console.WriteLine("Your weight on Neptune will be " + weight * 1.23 + "lbs.");
            }

        }

        public static void Part2()
        {
            //Calculator

            double number1, number2;
            string operation;


            Console.WriteLine("Pick a number!");
            Double.TryParse(Console.ReadLine(), out number1);

            

            Console.WriteLine("What will you be doing today?");
            Console.WriteLine("  1. Addition 2. Subtraction");
            Console.WriteLine("  3. Multiplication 4. Division");
            Console.WriteLine("  5. Square Root");

            

            operation = Console.ReadLine().ToLower();

            if (operation == "square root" || operation == "5")
            {
                Console.WriteLine("The square root of " + number1 + " is " + Math.Sqrt(number1) + ".");
                
            }
            else

                Console.WriteLine("Pick another!");
            Double.TryParse(Console.ReadLine(), out number2);

            if (operation == "addition" || operation == "1") 
            {
                Console.WriteLine(+ number1 +" + " + number2 + ",");
                Console.WriteLine(  "=" +number1 + number2);
            }

            if (operation == "subtraction" || operation == "2") 
            {
                Console.WriteLine( + number1 + " - " + number2 + ",");
                Console.WriteLine( "="     +(number1 - number2));
            }
            if (operation == "multiplication" || operation == "3") 
            {
                Console.WriteLine( + number2 + " x " + number2 + ",");
                Console.WriteLine( "=" +number2 * number1);
            }

            if (operation == "division" || operation == "4") 
            {
                Console.WriteLine( + number1 + " / " + number2 + ",");
                Console.WriteLine(  "=" +number1 / number2);
            }

        }

        public static void Part3()
        {

            //Quiz


            string name, ans1, ans2, ans3, ans4;
            int score;



            Console.WriteLine("Hello, and Welcome to the WW2 Quiz Show!!!");

            Console.WriteLine("So-What is your name, contestant?");
            name = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine(" Well, hello, " + name + "! Lets start this quiz! Every question will be in a True Or False format. Ready? Lets storm the           beaches!");

            Console.WriteLine("Ok, then! Question 1: True or False-The Normandy Landings were meant for June 5th, 1944, but postponed to June 6th due      to poor weather conditions.");

            ans1 = Console.ReadLine().ToLower();
            score = 0;

            Console.WriteLine();

            if (ans1 == "true" || ans1 == "t")
            {
                Console.WriteLine("Nice one!");

                score += 1;
            }

            else if (ans1 == "false" || ans1 == "f")
            {
                Console.WriteLine("Oh, darn! Unfortunatly for you, this WAS true.");
                
;           }

            else
            {
                 Console.WriteLine("How about you try next time.");
            }
            
            Console.WriteLine("Question 2! True or False-WW2 ended in 1944.");
            ans2 = Console.ReadLine().ToLower();

            Console.WriteLine();

            if (ans2 == "true" || ans2 == "t")
            {
                Console.WriteLine("Unfortunatly for you, you were wrong. WW2 ended in 1945.");
            }

            else if (ans2 == "false" || ans2 == "f")
            {
                Console.WriteLine("Nice one!");
                score += 1;
            }

            else
            {
                Console.WriteLine("Invalid Aswer");
            }
            
            Console.WriteLine();
            
            Console.WriteLine("Question 3: True or False-Germany had the most loss of men in WW2");
            ans3 = Console.ReadLine().ToLower();
            
            if (ans3 == "true" || ans3 == "t")
            {
                Console.WriteLine("False. The Soviet Union lost the most soldiers during WW2.");
            }

            else if (ans3 == "false" || ans3 == "f")
            {
                Console.WriteLine("Correct! Mr. Smartypants right here!");
                score += 1;
            }

            else
            {
                 Console.WriteLine("Too scared to try?");
            }
            Console.WriteLine("Final Question. True or False-Future president, John F. Kennedy served in the Pacific theatre during WW2. His PT boat          would be sunk by the Japanese.");
            ans4 = Console.ReadLine().ToLower();

            Console.WriteLine();
            
            if (ans4 == "true" || ans4 == "t")
            {
                Console.WriteLine("Nice!");
                score += 1;
            }

            else if (ans4 == "false" || ans4 == "f")
            {
                Console.WriteLine("Ouch! Hey, I didn't expect you to get that, but look into it. It's crazy!");
            }

            else 
            {
                Console.WriteLine("I understand why you wouldn't answer this question, but try next time.");
            }

            if (score == 4) 
            {
                Console.WriteLine("Congrats, " + name + "! 4 out of 4 is great! 100%! You are a certified history buff!");
            }

            if (score == 3) 
            {
                Console.WriteLine("Nice one, " + name + "! 3 out of 4 is pretty good-75%. The JFK one got you, didn't it?");
            }

            if (score == 2) 
            {
                Console.WriteLine("Ok, " + name + ", 2 out of 4 is still a pass-50%. You'll get 'em all next time!");
            }

            if (score == 1) 
            {
                Console.WriteLine("Damn, " + name + "... Unfortunatly, 1 out of 4, 25% is a fail.");
            }

            if (score == 0) 
            {
                Console.WriteLine("Wow, " + name + ". 0 out of 4... 0%. Did you even try?");
            }

            
            
           
            
            

            





        }
    }





}
    

