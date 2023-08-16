using AjaxDropdownListsExample.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AjaxDropdownListsExample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Instructor> instructors = GetInstructors();
            return View(instructors);
        }

        private List<Instructor> GetInstructors()
        {
            // Return a list of example instructors
            return new List<Instructor>
            {
                new Instructor { InstructorId = 1, InstructorName = "John Doe", InstructorEmail = "JDoe@test.com"},
                new Instructor { InstructorId = 2, InstructorName = "Jane Doe", InstructorEmail = "JaneDoe@test.com"},
                new Instructor { InstructorId = 3, InstructorName = "John Smith", InstructorEmail = "JSmith@test.com"}
            };
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
