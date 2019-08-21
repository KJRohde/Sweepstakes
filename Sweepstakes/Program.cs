using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Program
    {
        static void Main(string[] args)
        {
            SweepstakeManagerFactory factory = new SweepstakeManagerFactory();
            MarketingFirm firm = new MarketingFirm(factory.CreateManager();

            firm.RunSweepstakes();


        }
    }
}
