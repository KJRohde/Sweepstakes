using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    static class UserInterface
    {
        public static void GetContestantInformation(Sweepstakes sweepstakes)
        {
            Console.WriteLine("Please enter your first name");
            sweepstakes.contestant.firstName = Console.ReadLine();
            Console.WriteLine("Please enter your last name");
            sweepstakes.contestant.lastName = Console.ReadLine();
            Console.WriteLine("Please enter your home address");
            sweepstakes.contestant.emailAddress = Console.ReadLine();
            Console.WriteLine("Thank you for entering the sweepstakes!");
            sweepstakes.contestant.idNumber = (sweepstakes.contestants.Count + 1);
            Console.WriteLine("Your contest ID number is " + sweepstakes.contestant.idNumber + ".");
        }
        public static int GenerateRandomNumber(int min, int max)
        {
            Random random = new Random();
            int number = random.Next(min, max);
            return number;
        }
        public static void PrintContestant(Contestant contestant)
        {
            Console.WriteLine("First Name: " + contestant.firstName + ".");
            Console.WriteLine("Last Name: " + contestant.lastName + ".");
            Console.WriteLine("Email: " + contestant.emailAddress + "");
        }
    }
}
