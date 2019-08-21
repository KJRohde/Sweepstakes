using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Sweepstakes
    {
        //memebr variables
        public Dictionary<int, string> contestants = new Dictionary<int, string>();
        public int winner;
        public Contestant contestant;

        //construct
        public Sweepstakes(string name)
        {
        }
        //methods
        public void RegisterContestant(Contestant contestant)
        {
            UserInterface.GetContestantInformation(contestant);
            contestant.idNumber = (contestants.Count + 1);
            Console.WriteLine("Your contest ID number is " + contestant.idNumber + ".");
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
                    Console.WriteLine($"Contestant ID: {contestant.Key} Contestant Name: {contestant.Value} Contestant Email: {contestants[winner]}\nIs the winner.");
                    Console.ReadLine();
            }
        }
    }
}
