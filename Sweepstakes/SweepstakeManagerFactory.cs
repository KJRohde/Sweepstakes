using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakeManagerFactory
    {
        public static ISweepstakesManager CreateManager(string managerType)
        {
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
                    CreateManager(managerType);
                    break;
            }
            return manager;
        }
    }
}
