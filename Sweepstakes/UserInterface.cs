using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    static class UserInterface
    {
        public static void GetContestantInformation(Contestant contestant, Sweepstakes sweepstakes)
        {
            Console.WriteLine("Please enter your first name");
            contestant.firstName = Console.ReadLine();
            Console.WriteLine("Please enter your last name");
            contestant.lastName = Console.ReadLine();
            Console.WriteLine("Please enter your home address");
            contestant.emailAddress = Console.ReadLine();
            Console.WriteLine("Thank you for entering the sweepstakes!");
            contestant.idNumber = (sweepstakes.contestants.Count + 1);
            Console.WriteLine("Your contest ID number is " + contestant.idNumber + ".");
        }
    }
}
