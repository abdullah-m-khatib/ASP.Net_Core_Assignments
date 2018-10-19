using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeveloperGallery.ViewModels
{
    public class ProjectsViewModel
    {
        public List<Models.Project> Projects { get; set; }

        public ProjectsViewModel() { }

        public ProjectsViewModel(List<Models.Project> projects)
        {
            Projects = projects;
        }

    }
}
