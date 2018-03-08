using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectNGU.Models;
using ProjectNGU.ViewModels;

namespace ProjectNGU.Controllers
{
    public class ProfileController : Controller
    {
        private readonly IProfileRepository _profileRepository;

        public ProfileController(IProfileRepository profileRepository)
        {
            _profileRepository = profileRepository;
        }

        public IActionResult Login()
        {
            var profileViewModel = new ProfileViewModel()
            {
                Title = "Login"
            };

            return View(profileViewModel);
        }

        //[Route("[controller]/ProfileSettings/{id}")]
        public IActionResult ProfileSettings(int id)
        {
            var user = _profileRepository.GetUserByUserId(id);

            if(user == null)
            {
                return NotFound();
            }

            return View(new ProfileSettingsViewModel() { Title = "Profile Settings", User = user });
        }
    }
}