using Microsoft.AspNetCore.Mvc;
using Models_IN_DotnetCore.Models;
using System.Diagnostics;
using System.Reflection;
using System.Xml.Linq;

namespace Models_IN_DotnetCore.Controllers
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
            var Students = new List<Student>
            {
                 new Student { RollNo =1,Name="Akash Mishra",Gender ="Male",Standerd=12},
                 new Student { RollNo =2,Name="Adarsh Upadhyay",Gender ="Male",Standerd=12},
                 new Student { RollNo =3,Name="Akhilesh Baniya",Gender ="Male",Standerd=12},
                 new Student { RollNo =4,Name="Adatiya Singh",Gender ="Male",Standerd=12},
                 new Student { RollNo =5,Name="Ankit Mishra",Gender ="Male",Standerd=12},
                 new Student { RollNo =6,Name="Anurag Verma",Gender ="Male",Standerd=12},
            };

            ViewBag.student = Students;
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
