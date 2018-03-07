using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectNGU.Model
{
    public class User
    {
        public int UserId { get; set; }
        public string LegalFirstName { get; set; }
        public string LegalMiddleName { get; set; }
        public string LegalLastName { get; set; }
        public string PreferredFirstName { get; set; }
        public string FormerLegalLastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public Address ResidentialAddress { get; set; }
        public Address MailingAddress { get; set; }
    }
}
