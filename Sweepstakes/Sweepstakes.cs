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
        public Dictionary<int, Contestant> contestants = new Dictionary<int, Contestant>();
        public int winner;
        public string name;

        //construct
        public Sweepstakes(string name)
        {
            this.name = name;
        }
        //methods
        public void RegisterContestant(Contestant contestant)
        {
            Console.Clear();
            contestant = UserInterface.GetContestantInformation(contestant);
            contestant.idNumber = (contestants.Count + 1);
            Console.WriteLine("Your contest ID number is " + contestant.idNumber + ".");
            Console.ReadLine();
            contestants.Add(contestant.idNumber, contestant);
        }
        public int GetWinner()
        {
            winner = UserInterface.GenerateRandomNumber(1, contestants.Count);
            return winner;
        }
        public void PrintContestantInfo()
        {
            GetWinner();
            foreach (KeyValuePair<int, Contestant> contestant in contestants)
            {
                if (contestant.Key == winner)
                {
                    Console.WriteLine("The winner of " + name + " is:");
                    UserInterface.PrintContestant(contestant.Value);
                    Console.ReadLine();
                }
            }
        }
    }
}
