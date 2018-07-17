using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3EvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string userName;

                Console.WriteLine("What is your name?");
                userName = Console.ReadLine();

                Console.WriteLine("Hello " + userName + ", today we are going to find out if a number is even or odd.");

                int userNumber = ConvertUserNumber();                        
                
                if (userNumber % 2 == 0 && Enumerable.Range(2, 25).Contains(userNumber))
                {
                    Console.WriteLine(userName + ", " + userNumber + " is even and less than 25.");
                    Console.ReadLine();
                }
                else if (userNumber % 2 == 0 && Enumerable.Range(26, 60).Contains(userNumber))
                {
                    Console.WriteLine(userName + ", that number is even");
                    Console.ReadLine();
                }
                else if (userNumber % 2 == 0 && Enumerable.Range(61, 100).Contains(userNumber))
                {
                    Console.WriteLine(userName + ", " + userNumber + " is even");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine(userName + ", " + userNumber + " is Odd");
                    Console.ReadLine();
                }
                Console.WriteLine("Do you want to run again (Y/N)? ");

                if (Console.ReadLine().ToLower() != "y")
                {
                    Console.WriteLine("Thank you for playing");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    return;
                }

            }
        }


        static int ConvertUserNumber()
        {
            string stringNumber;
            int userNumber;
            Console.WriteLine("\n" + "Please enter in a valid number between 1 and 100.");
            stringNumber = Console.ReadLine();
            bool succes = int.TryParse(stringNumber, out userNumber);
            if (!succes)
            {
                Console.WriteLine("\n" + "Please enter in a valid number");
                return ConvertUserNumber();
            }
            if (userNumber >=101 || userNumber <= 0)
            {
                Console.WriteLine("Please enter in a valid number between 1 and 100.");
                return ConvertUserNumber();
            }
            return userNumber;

        }
    }
}
