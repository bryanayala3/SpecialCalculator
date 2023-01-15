/*
 * Program ID: A3JRBAP1
 * 
 * Purpose: Do Assignment 3
 * 
 * Revision History:
 * Created by Bryan Ayala and Joel Rivas Oct 29, 2022
 * 
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3JRBAP1
{
    class Program
    {
        static void Option1()
        {
            int i = 0;
            double number = 0;
            double number2 = 0;
            bool valid = true;
            string userInput = "";

            Console.WriteLine("You could see a list of 20 numbers since the number that you input");
            Console.WriteLine("Please Enter your number: ");
            userInput = Console.ReadLine();

            while (valid)
            {
                try
                {
                    number = Convert.ToDouble(userInput);
                }
                catch(FormatException)
                {
                    Console.WriteLine("ERROR. You have introduced text. Please Enter your number again: ");
                    userInput = Console.ReadLine();
                }
                if (number > 0 || number < 0)
                {
                    valid = false;
                }
            }
            for (i = 1; i < 21; i++)
            {
                Console.WriteLine(i + ". The number is: " + number);

                if (number % 2 == 0)
                {
                    number2 = number * 3;
                    Console.WriteLine(i + ". The number above is an even number so the result after multiply for 3 is: " + number2);
                }
                else if (number % 2 != 0)
                {
                    number2 = number * 4;
                    Console.WriteLine(i + ". The number above is an odd number so the result after multiply for 4 is: " + number2);
                }

                number = number + 1;
                Console.WriteLine();
            }

        }

        static void Option2()
        {
            double number = 0;
            double result = 0;
            bool contCalculate = true;
            string answer = "";
            int comparer = 0;

            Console.WriteLine("This is a calculator that the number that you introduce it will divide by 3");

            while (contCalculate)
            {
                Console.WriteLine("Enter your number or Enter END to finish the calculate: ");
                answer = Console.ReadLine();

                comparer = string.Compare(answer, "end", true);

                if (comparer == 0)
                    contCalculate = false;


                else
                {
                    try
                    {
                        number = Convert.ToDouble(answer);
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine();
                        Console.WriteLine("You have introduced a different text than END");
                        Console.WriteLine("Automatically your number is 0");
                        Console.WriteLine();
                        number = 0;
                    }
                    result = number / 3;

                    Console.WriteLine("The result is: " + result);

                    Console.WriteLine();
                }

            }
        }

        static void Main(string[] args)
        {
            //Declare variables
            bool keepGoing;
            string userAnswer;
            int answerOption;
            bool validationString;

            //Initialize variables
            keepGoing = true;
            userAnswer = "";
            answerOption = 0;
            validationString = true;

            Console.WriteLine("This is a special calculator.\nThe option 1 will show you different consecutive numbers since your number.\nThe option 2 will help you to divide your special number.\nAnd the option 3 is to exit of this special calculator");


            do
            {
                Console.WriteLine("To First option Press 1");
                Console.WriteLine("To Second option Press 2");
                Console.WriteLine("To exit Press 3");
                userAnswer = Console.ReadLine();
                


                while (validationString)
                {
                    try
                    {
                        answerOption = int.Parse(userAnswer);
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("ERROR. You have introduced a text or decimal option. Please choose again");
                        Console.WriteLine();
                        Console.WriteLine("To First option Press 1");
                        Console.WriteLine("To Second option Press 2");
                        Console.WriteLine("To exit Press 3");

                        userAnswer = Console.ReadLine();
                    }

                    if (answerOption > 0 || answerOption < 0 && answerOption%1==0)
                    {
                        validationString = false;
                    }
                }

                if (answerOption == 1)
                {
                    Option1();

                }
                else if (answerOption == 2)
                {
                    Option2();

                }
                else if (answerOption == 3)
                {
                    keepGoing = false;

                    Console.WriteLine("See you later!!!");
                }


                else if (answerOption < 1 || answerOption > 3)
                {
                    try
                    {
                        throw new ArgumentOutOfRangeException();

                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        Console.WriteLine("ERROR. You have introduced invalid option. Please choose again");
                        Console.WriteLine();
                    }

                }

                answerOption = 0;
                validationString = true;

            } while (keepGoing);

            Console.ReadKey();
        }
    }
}
