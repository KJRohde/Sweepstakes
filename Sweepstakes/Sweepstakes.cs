using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes
    {
        //memebr variables
        public Dictionary<int, string> contestants = new Dictionary<int, string>();
        public Contestant contestant;
        public int winner;
        //construct

        //methods
        public void RegisterContestant()
        {
            UserInterface.GetContestantInformation(contestant, this);
            contestants.Add(contestant.idNumber, "" + contestant.firstName + " " + contestant.lastName + "");

        }
        public int ChooseWinner()
        {
            winner = UserInterface.GenerateRandomNumber(1, contestants.Count);
            return winner;
        }
        public void PrintContestantInfo()
        {
            foreach (KeyValuePair<int, string> contestant in contestants)
            {
                if (contestant.Key == winner)
                    Console.WriteLine($"Contestant ID: {contestant.Key} Contestant Name: {contestant.Value} Contestant Email {contestant.emailAddress}");
            }
        }
    }
}
