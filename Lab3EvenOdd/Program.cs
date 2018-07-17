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
                int userNumber = ConvertUserNumber();
                if (userNumber % 2 == 0 && Enumerable.Range(2, 25).Contains(userNumber))
                {
                    Console.WriteLine(userNumber + " Even and less than 25.");
                    Console.ReadLine();
                }
                else if (userNumber % 2 == 0 && Enumerable.Range(26, 60).Contains(userNumber))
                {
                    Console.WriteLine("Even");
                    Console.ReadLine();
                }
                else if (userNumber % 2 == 0 && Enumerable.Range(61, 100).Contains(userNumber))
                {
                    Console.WriteLine(userNumber + " Even");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine(userNumber + " Odd");
                    Console.ReadLine();
                }
                Console.WriteLine("Do you want to run again (Y/N)? ");

                if (Console.ReadLine().ToLower() != "y")
                    Console.WriteLine("Thank you for playing");
                    Console.ReadLine();
                    break;
            }
        }


        static int ConvertUserNumber()
        {
            string stringNumber;
            int userNumber;
            Console.WriteLine("\n" + "Please enter in a number between 1 and 100.");
            stringNumber = Console.ReadLine();
            bool succes = int.TryParse(stringNumber, out userNumber);
            if (succes == true)
            {
                return userNumber;
            }
            else
                Console.WriteLine("\n" + "Please enter in a valid number");
            return ConvertUserNumber();
        }
    }
}
