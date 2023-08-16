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

        public IActionResult GetCourses(int instructorId)
        {
            List<Course> courses = GetCoursesByInstructorId(instructorId);
            // Return the course data as JSON to be consumed by the AJAX call
            return Json(courses);
        }

        private List<Course> GetCoursesByInstructorId(int instructorId)
        {
            // Return fake courses here. In a real application, you would query a database using the instructorId parameter
            return new List<Course>
            {
                new Course { CourseId = 1, CourseName = "Course 1", NumberOfCredits = 3 },
                new Course { CourseId = 2, CourseName = "Course 2", NumberOfCredits = 4 },
                new Course { CourseId = 3, CourseName = "Course 3", NumberOfCredits = 3 },
                new Course { CourseId = 4, CourseName = "Course 4", NumberOfCredits = 4 },
                new Course { CourseId = 5, CourseName = "Course 5", NumberOfCredits = 3 },
                new Course { CourseId = 6, CourseName = "Course 6", NumberOfCredits = 4 },
                new Course { CourseId = 7, CourseName = "Course 7", NumberOfCredits = 3 },
                new Course { CourseId = 8, CourseName = "Course 8", NumberOfCredits = 4 },
                new Course { CourseId = 9, CourseName = "Course 9", NumberOfCredits = 3 },
                new Course { CourseId = 10, CourseName = "Course 10", NumberOfCredits = 4 }
            };
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
