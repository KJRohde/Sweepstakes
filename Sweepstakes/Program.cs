﻿using System;
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
            MarketingFirm firm = new MarketingFirm(SweepstakeManagerFactory.CreateManager());

            firm.RunSweepstakes();
            firm.FinishSweepstakes();
        }
    }
}
