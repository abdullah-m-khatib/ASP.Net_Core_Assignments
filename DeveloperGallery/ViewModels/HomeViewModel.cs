using DeveloperGallery.Models;
using DeveloperGallery.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeveloperGallery.ViewModels
{
    public class HomeViewModel
    {
        public User User { get; set; }

        public ProjectsViewModel ProjectsViewModel { get; set; }

        public HomeViewModel(User user,ProjectsViewModel projectsViewModel)
        {
            User = user;
            ProjectsViewModel = projectsViewModel;
        }
    }
}
