﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    static class UserInterface
    {
        public static void GetContestantInformation(Contestant contestant)
        {
            Console.WriteLine("Please enter your first name");
            contestant.firstName = Console.ReadLine();
            Console.WriteLine("Please enter your last name");
            contestant.lastName = Console.ReadLine();
            Console.WriteLine("Please enter your home address");
            contestant.emailAddress = Console.ReadLine();
            Console.WriteLine("Thank you for entering the sweepstakes!");
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
