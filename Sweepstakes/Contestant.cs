using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Contestant
    {
        //memeber variables
        public string firstName;
        public string lastName;
        public string emailAddress;
        public int idNumber;
        //Construct
        public Contestant(string firstName, string lastName, string emailAddress, int idNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.emailAddress = emailAddress;
            this.idNumber = idNumber;
        }
        //methods
    }
}
