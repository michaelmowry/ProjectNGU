using ProjectNGU.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectNGU.Models
{
    public class ProfileRepository : IProfileRepository
    {
        private readonly MockProfileRepository _appDbContext;

        public ProfileRepository(MockProfileRepository appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public User GetUserByUserId(int userId)
        {
            return _appDbContext.GetUserByUserId(userId);
        }
    }
}
