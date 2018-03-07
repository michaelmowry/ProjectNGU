using ProjectNGU.Model;
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
                new User {UserId = 1, LegalFirstName = "Apple Pie", LegalLastName = "Mowry"},
                new User {UserId = 2, LegalFirstName = "Blueberry Cheese Cake", LegalLastName = "Mowry"},
                new User {UserId = 3, LegalFirstName = "Cheese Cake", LegalLastName = "Mowry"},
                new User {UserId = 4, LegalFirstName = "Cherry Pie", LegalLastName = "Mowry"},
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