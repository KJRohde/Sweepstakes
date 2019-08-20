using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakeManagerFactory
    {
        SweepstakesStackManager stackManager = new SweepstakesStackManager();
        SweepstakesQueueManager queueManager = new SweepstakesQueueManager();

        public void ChooseStackQueue()
        {
            Console.WriteLine("Would you like to use a stack or a queue for your sweepstakes?");
            Console.WriteLine("Please enter '1' for stack, or '2' for queue");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("You have chosen to stack.");
                    stackManager.InsertSweepstakes();
                    break;
                case "2":
                    Console.WriteLine("You have chosen to queue.");
                    queueManager.InsertSweepstakes();
                    break;
                default:
                    ChooseStackQueue();
                    break;
            }
        }
    }
}
