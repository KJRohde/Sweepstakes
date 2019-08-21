using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class MarketingFirm
    {
        public Sweepstakes sweepstakes;
        public int numberOfSweepstakes;
        ISweepstakesManager manager;
        public int sweepstakeCounter;
        public string managerType;


        MarketingFirm(ISweepstakesManager manager)
        {
            this.manager = manager;
            sweepstakeCounter = 0;
        }
        public void RunSweepstakes()
        {
            managerType = GetManagerType();
            AddManager(managerType);
            GetNumberOfSweepstakes();
            while (sweepstakeCounter <= numberOfSweepstakes)
            {
                sweepstakes.RegisterContestant(sweepstakes.contestant);
                AskToAdd();
                manager.InsertSweepstakes(sweepstakes);
                sweepstakeCounter++;
            }
            while (numberOfSweepstakes > 0)
            {
                manager.GetSweepstakes();
                sweepstakes.ChooseWinner();
                sweepstakes.PrintContestantInfo();
                numberOfSweepstakes--;
            }
        }
        public void AskToAdd()
        {
            Console.WriteLine("Would you like to register more contestants? Enter yes or no");
            switch (Console.ReadLine())
            {
                case "yes":
                    sweepstakes.RegisterContestant(sweepstakes.contestant);
                    AskToAdd();
                    break;
                case "no":
                    Console.WriteLine("This sweepstakes now has all contestants registered.");
                    Console.ReadLine();
                    break;
                default:
                    AskToAdd();
                    break;
            }
        }
        public int GetNumberOfSweepstakes()
        {
            Console.WriteLine("Please enter how many sweepstakes you would like to run.");
            numberOfSweepstakes = int.Parse(Console.ReadLine());
            return numberOfSweepstakes;

        }

        public string GetManagerType()
        {
            Console.WriteLine("Would you like to use a stack or a queue for your sweepstakes?");
            Console.WriteLine("Please enter 'stack', or 'queue'");
            string input = Console.ReadLine();
            return input;

        }
        public void AddManager(string managerType)
        {
            ISweepstakesManager manager = SweepstakeManagerFactory.CreateManager(managerType);
        }
    }
}
