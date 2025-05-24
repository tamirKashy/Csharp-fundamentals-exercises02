using System;
using System.Numerics;

namespace Csharp_fundamentals_exercises02
{
    class Program
    {
        static void Main(string[] args)
        {
            taskpick();
        }

        static void taskpick()
        {
            int input;
            Console.WriteLine("Please select a Task: ");
            input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    task01();
                    break;
                case 2:
                    task02();
                    break;
                case 3:
                    task03();
                    break;
                case 4:
                    task04();
                    break;
                case 5:
                    task05();
                    break;
                default:
                    taskpick();
                    break;
            }
        }
        static void task01()
        {
            /*
             * Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. Display the count on the console
             */
            int counter = 0, from, target;
            from = 1;
            target = 100;
            for (float i = (float)from; i <= (float)target; i++)
            {
                if(i%3 == 0) counter++;
            }
            Console.WriteLine("The amount of numbers divisible by 3 is {0}.",counter);
        }
        static void task02()
        {
            /*
             * Write a program and continuously ask the user to enter a number or "ok" to exit.
             * Calculate the sum of all the previously entered numbers and display it on the console.
             */
            int sum = 0;
            string input;
            Console.WriteLine("Please enter numbers or ok to finish: ");
            while (true)
            {
                
                input = Console.ReadLine();
                if(input == "ok")
                    break;
                else if(!String.IsNullOrWhiteSpace(input))
                {
                    sum += Convert.ToInt32(input);
                    Console.Write("+ ");
                    continue;
                }
            }
            Console.WriteLine("The sum of all numbers You entered is {0}.", sum);
        }
        static void task03()
        {
            /*
             * Write a program and ask the user to enter a number.
             * Compute the factorial of the number and print it on the console.
             * For example, if the user enters 5,
             * the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
             */
            BigInteger factorial = 1;
            string input;
            Console.WriteLine("Please enter numbers to find the factorial of this number: ");
            input = Console.ReadLine();
            for (long i = 1; i < int.Parse(input); i++)
            {
                factorial = factorial * (BigInteger)i;
            }
            Console.WriteLine("The factorial of this number is {0}.", factorial);
        }
        static void task04()
        {
            /*Write a program that picks a random number between 1 and 10.
             Give the user 4 chances to guess the number.
              If the user guesses the number, display “You won"; otherwise, display “You lost".
               (To make sure the program is behaving correctly, you can display the secret number on the console first.)*/
            int chances = 4, pickedNumber;
            string input;
            Random rand = new Random();
            pickedNumber = rand.Next(1, 10);
            while (true)
            {
                Console.WriteLine("Please enter a number between 1 and 10: ");
                input = Console.ReadLine();
                if (Convert.ToInt32(input) == pickedNumber) break;
                chances--;
                if (chances < 1) break;
                else Console.WriteLine("Not correct, You have {0} move chances to guess the number: ", chances);
            }
            if (chances > 0) Console.WriteLine("You won!");
            else Console.WriteLine("You lost! The picked number was {0}", pickedNumber);
        }
        static void task05()
        {
            /*
             *Write a program and ask the user to enter a series of numbers separated by comma.
             * Find the maximum of the numbers and display it on the console.
             * For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.
             */
            int max = 0;
            string input;
            Console.WriteLine("enter a series of numbers separated by comma:\n(For example, if the user enters “5, 3, 8, 1, 4\", the program should display 8)\n");
            input = Console.ReadLine();
            var numbers = input.Split(',');
            var num =Convert.ToInt32(numbers[0]);
            max = num;
            foreach (string number in numbers)
            {
                 num = Convert.ToInt32(number);
                if (num > max) max = num;
            }
            Console.WriteLine("The max number is {0}.", max);

        }
    }
}