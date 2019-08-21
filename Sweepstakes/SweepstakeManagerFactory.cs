using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakeManagerFactory
    {
        //parameter for function
        public static ISweepstakesManager CreateManager()
        {
            Console.WriteLine("Would you like to use a stack or a queue for your sweepstakes?");
            Console.WriteLine("Please enter 'stack', or 'queue'");
            string managerType = Console.ReadLine();
            ISweepstakesManager manager = null;
            switch (managerType)
            {
                case "stack":
                    Console.WriteLine("You have chosen to stack.");
                    manager = new SweepstakesStackManager();
                    break;
                case "queue":
                    Console.WriteLine("You have chosen to queue.");
                    manager = new SweepstakesQueueManager();
                    break;
                default:
                    Console.WriteLine("Please enter 1 for stack or 2 for queue.");
                    CreateManager();
                    break;
            }
            return manager;
        }
    }
}
