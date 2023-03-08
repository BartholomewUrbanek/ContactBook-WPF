using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBook_WPF
{
    internal class Contact
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string contactNumber { get; set; }
        public string emailAddress { get; set; }
        public string homeAddress { get; set; }

        public Contact(string firstName, string lastName, string contactNumber,string emailAddress, string homeAddress)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.contactNumber = contactNumber;
            this.emailAddress = emailAddress;
            this.homeAddress = homeAddress;

        }
    }
}
