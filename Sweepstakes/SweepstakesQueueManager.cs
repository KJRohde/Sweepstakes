using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        Queue<Sweepstakes> sweepstakeStack = new Queue<Sweepstakes>();
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            sweepstakeStack.Enqueue(sweepstakes);
        }
        Sweepstakes GetSweepstakes()
        {

        }
    }
}
