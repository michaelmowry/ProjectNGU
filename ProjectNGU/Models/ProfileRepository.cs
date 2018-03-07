using ProjectNGU.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectNGU.Models
{
    public class ProfileRepository : IProfileRepository
    {
        private readonly AppDbContext _appDbContext;

        public ProfileRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public User GetUserByUserId(int userId)
        {
            return _appDbContext.Users.FirstOrDefault(p => p.UserId == userId);
        }
    }
}
