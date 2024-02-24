using Microsoft.AspNetCore.Mvc;
using ProjectOrganizer.Models;
using ProjectOrganizer.Services;
using System.Diagnostics;

namespace ProjectOrganizer.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        // private readonly ProjectService _projectService;
        private readonly ProjectService projectService;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            // _projectService = projectService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Test()
        {
            // BUGFIX: System.NullReferenceException: "Object reference not set to an instance of an object."

            var projectService = HttpContext.RequestServices.GetService<ProjectService>();
            var projects = projectService.GetProjects();
            return View(projects);

            // var projects = _projectService.GetProjects();
            // return View(projects);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
