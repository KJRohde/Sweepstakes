using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesStackManager : ISweepstakesManager
    {

        Stack<Sweepstakes> sweepstakeStack = new Stack<Sweepstakes>();
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            sweepstakeStack.Push(sweepstakes);
        }
        Sweepstakes GetSweepstakes()
        {

        }
    }
}
