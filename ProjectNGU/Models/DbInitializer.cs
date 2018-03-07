using ProjectNGU.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectNGU.Models
{
    public class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.Users.Any())
            {
                context.AddRange(
                    new User { LegalFirstName = "Michael", LegalLastName = "Mowry", PreferredFirstName = null, FormerLegalLastName = null, LegalMiddleName = "Shane", Gender = "Male", BirthDate = new DateTime(1977, 11, 15), ResidentialAddress = new Address { StreetAddressLine1 = "1367 S. Country Club Dr.", StreetAddressLine2 = "Unit 1014", City = "Mesa", State = "AZ", ZipCode = "85210" }, MailingAddress = new Address { StreetAddressLine1 = "1367 S. Country Club Dr.", StreetAddressLine2 = "Unit 1014", City = "Mesa", State = "AZ", ZipCode = "85210" } },
                    new User { LegalFirstName = "Harper", LegalLastName = "Mowry", PreferredFirstName = null, FormerLegalLastName = null, LegalMiddleName = "Jade", Gender = "Female", BirthDate = new DateTime(2008, 8, 24), ResidentialAddress = new Address { StreetAddressLine1 = "1367 S. Country Club Dr.", StreetAddressLine2 = "Unit 1014", City = "Mesa", State = "AZ", ZipCode = "85210" }, MailingAddress = new Address { StreetAddressLine1 = "1367 S. Country Club Dr.", StreetAddressLine2 = "Unit 1014", City = "Mesa", State = "AZ", ZipCode = "85210" } }
                );
            }

            context.SaveChanges();
        }
    }
}
