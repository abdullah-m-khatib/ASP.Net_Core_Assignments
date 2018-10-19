using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DeveloperGallery.Models;
using DeveloperGallery.ViewModels;

namespace DeveloperGallery.Controllers
{
    public class HomeController : Controller
    {
        readonly string footer = "Abdu Khteeb - This is Assignment #2";

        public IActionResult Index()
        {
            ViewBag.Footer = footer;

            var user = Helpers.Seed.Users.First();

            var projects = Helpers.Seed.Projects.Take(3).ToList();

            if (projects is null) return NotFound();
            else
            {
                var projectsViewModel = new ProjectsViewModel(projects);

                var vm = new HomeViewModel(user, projectsViewModel);
                return View(vm);
            }
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
