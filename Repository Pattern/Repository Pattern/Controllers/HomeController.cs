using Microsoft.AspNetCore.Mvc;
using Repository_Pattern.Models;
using Repository_Pattern.Repository;
using System.Diagnostics;

namespace Repository_Pattern.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public iStudent _studentRepo;  // Change to the interface type

        // Constructor injection for logger and iStudent
        public HomeController(ILogger<HomeController> logger, iStudent studentRepo)
        {
            _logger = logger;
            _studentRepo = studentRepo;  // Use the injected repo
        }

      

        public IActionResult Index()
        {
            var students = _studentRepo.Get_AllStudents(); // Get all students
            return View(students); // Pass the student list to the view
        }


        public IActionResult Details(int id) 
        {
            var student = _studentRepo.Get_AllStudentsBYid(id); // Fetch the student by ID

            if (student == null)
            {
                return NotFound(); // Return a 404 if the student is not found
            }

            return View(student); // Pass the student to the view
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
