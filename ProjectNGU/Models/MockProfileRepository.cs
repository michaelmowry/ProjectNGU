using ProjectNGU.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectNGU.Models
{
    public class MockProfileRepository : IProfileRepository
    {
        private List<User> _users;
        public MockProfileRepository()
        {
            if (_users == null)
            {
                InitializeUsers();
            }
        }

        private void InitializeUsers()
        {
            _users = new List<User>
            {
                    new User { UserId = 1, LegalFirstName = "Michael", LegalLastName = "Mowry", PreferredFirstName = null, FormerLegalLastName = null, LegalMiddleName = "Shane", Gender = "Male", BirthDate = new DateTime(1977, 11, 15), ResidentialAddress = new Address { AddressId = 1, StreetAddressLine1 = "1367 S. Country Club Dr.", StreetAddressLine2 = "Unit 1014", City = "Mesa", State = "AZ", ZipCode = "85210" }, MailingAddress = new Address { AddressId = 2, StreetAddressLine1 = "1367 S. Country Club Dr.", StreetAddressLine2 = "Unit 1014", City = "Mesa", State = "AZ", ZipCode = "85210" } },
                    new User { UserId = 2, LegalFirstName = "Harper", LegalLastName = "Mowry", PreferredFirstName = null, FormerLegalLastName = null, LegalMiddleName = "Jade", Gender = "Female", BirthDate = new DateTime(2008, 8, 24), ResidentialAddress = new Address { AddressId = 3, StreetAddressLine1 = "1367 S. Country Club Dr.", StreetAddressLine2 = "Unit 1014", City = "Mesa", State = "AZ", ZipCode = "85210" }, MailingAddress = new Address { AddressId = 4, StreetAddressLine1 = "1367 S. Country Club Dr.", StreetAddressLine2 = "Unit 1014", City = "Mesa", State = "AZ", ZipCode = "85210" } }
            };
        }

        public IEnumerable<User> GetUsers()
        {
            return _users;
        }

        public User GetUserByUserId(int userId)
        {
            return _users.FirstOrDefault(p => p.UserId == userId);
        }
    }
}