using DeveloperGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeveloperGallery.ViewModels
{
    public class ProjectDetailsViewModel
    {
        public Project Project { get; set; }

        public ProjectDetailsViewModel(Project project)
        {
            Project = project;
        }
    }
}