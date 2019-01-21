/*
    Author: Tharick Moulton
    Date: 1/21/2019
    Comments: This C# Console application code demonstrates the use of
              iterative statements after getting input from users. 
*/



using System;

namespace Iterative_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ask the user for input
            Console.WriteLine("Please enter an integer value between 1 and 100.");

            /*
                  Statements below uses the try catch block to validate user input.
                  If the user provides bad input, the catch block
                  will handle the error and a message will be displayed.
               */
            try
            {
                // This variable will gather data from user input
                string userInput = Console.ReadLine();

                int Input_entered = int.Parse(userInput);


                if ((Input_entered > 0) && (Input_entered <= 100))
                {
                    Console.WriteLine("Executing a Do While Loop!");
                    Console.WriteLine("The Do While Loop will iterate " + Input_entered.ToString() + " times.");
                    // Do While Loop
                    do
                    {
                        Console.WriteLine("The value of the iterative variable is: " + Input_entered.ToString());
                        Input_entered--;
                    } while (Input_entered > 0);
                    Console.WriteLine("Press any key to exit the program ...");
                    Console.ReadKey(true);
                }
                // If the user does not enter a value between 1 and 100, display a message
                else
                {
                    Console.WriteLine("Please enter an integer between 1 and 100 and try again ...");
                    Console.WriteLine("Press any key to exit the program and try again ...");
                    Console.ReadKey(true);
                }
            } // End of try
            catch
            {
                Console.WriteLine("Please enter an integer value and try running the program again ...");
                Console.WriteLine("Press any key to exit the program ...");
                Console.ReadKey(true);
            }
        }
    }
}


              