using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectNGU.ViewModels;

namespace ProjectNGU.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Login()
        {
            var profileViewModel = new ProfileViewModel()
            {
                Title = "Login"
            };

            return View(profileViewModel);
        }

        public IActionResult ProfileSettings()
        {
            ViewBag.Ttile = "Login";

            return View();
        }
    }
}