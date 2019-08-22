using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class MarketingFirm
    {
        // public Sweepstakes sweepstakes;
        public int numberOfSweepstakes;
        ISweepstakesManager manager;
        public int sweepstakeCounter;
        public int allowedContestants;


        public MarketingFirm(ISweepstakesManager manager)
        {
            this.manager = manager;
            sweepstakeCounter = 0;
        }
        public void RunSweepstakes()
        {
            GetNumberOfSweepstakes();
            for (int i = 0; i < numberOfSweepstakes; i++)
            {
                Console.Clear();
                Sweepstakes sweepstakes = new Sweepstakes(UserInterface.NameSweepstakes());
                AskToAdd();
                for (int j = 0; j < allowedContestants; j++)
                {
                    sweepstakes.RegisterContestant(new Contestant()) ;
                }
                manager.InsertSweepstakes(sweepstakes);
            }
        }
        public void FinishSweepstakes()
        {
            for (int i = numberOfSweepstakes; i > 0; i--)
            {
                Sweepstakes sweepstakes = manager.GetSweepstakes();
                sweepstakes.PrintContestantInfo();
                numberOfSweepstakes--;
            }
        }
        public void AskToAdd()
        {
            Console.WriteLine("How many contestants will you allow in this sweepstakes?");
            allowedContestants = int.Parse(Console.ReadLine());
        }
        public int GetNumberOfSweepstakes()
        {
            Console.WriteLine("Please enter how many sweepstakes you would like to run.");
            numberOfSweepstakes = int.Parse(Console.ReadLine());
            return numberOfSweepstakes;
        }
    }
}
