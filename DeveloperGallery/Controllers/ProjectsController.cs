using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeveloperGallery.ViewModels;
using DeveloperGallery.Models;
using Microsoft.AspNetCore.Mvc;

namespace DeveloperGallery.Controllers
{
    public class ProjectsController : Controller
    {
        readonly string footer = "Abdu Khteeb - This is Assignment #2";

        public IActionResult Index()
        {
            ViewBag.Footer = footer;

            var projects = Helpers.Seed.Projects.ToList();

            if (projects is null) return NotFound();
            else
            {
                var vm = new ProjectsViewModel(projects);
                return View(vm);
            }
        }

        public IActionResult ProjectDetails(int id)
        {
            ViewBag.Footer = footer;

            var project = Helpers.Seed.Projects.FirstOrDefault(p => p.Id == id);

            if (project is null) return NotFound();
            else
            {
                var vm = new ProjectDetailsViewModel(project);
                return View(vm);
            }
        }

    }
}
