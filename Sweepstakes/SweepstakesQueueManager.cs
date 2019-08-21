using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        Queue<Sweepstakes> sweepstakeQueue = new Queue<Sweepstakes>();
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            sweepstakeQueue.Enqueue(sweepstakes);
        }
        public Sweepstakes GetSweepstakes()
        {
            Console.WriteLine("Got it");
            return sweepstakeQueue.Dequeue();
        }
    }
}
