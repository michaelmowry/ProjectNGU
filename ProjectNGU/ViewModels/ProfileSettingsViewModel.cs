using ProjectNGU.Model;
using ProjectNGU.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectNGU.ViewModels
{
    public class ProfileSettingsViewModel
    {
        public string Title { get; set; }

        public Model.User User { get; set; } 
    }
}
