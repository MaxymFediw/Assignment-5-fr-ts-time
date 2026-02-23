using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace Assignment_5_fr_ts_time
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Part2();
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
    }





}
    

