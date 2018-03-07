using ProjectNGU.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectNGU.Models
{
    public interface IProfileRepository
    {
        User GetUserByUserId(int UserId);
    }
}
