using Microsoft.AspNetCore.Mvc;
using Passing_data_From_Controller_ti_View_Using_ViewBag.Models;
using System.Diagnostics;

namespace Passing_data_From_Controller_ti_View_Using_ViewBag.Controllers
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
            ViewBag.Name = "Akash Mishra";
            ViewBag.Age = "23";
            ViewBag.Date = DateTime.Now.ToShortDateString();

            string[] arr = { "Akash", "Adarsh", "Akhilesh", "Adatiya", "Ankit" };

            ViewBag.Array = arr;

            ViewBag.Languages = new List<string>()
            {
                "C",
                "C++",
                "Java",
                "JavaScript",
                "C#",
                "SQL"
            };


            // accessing view data using viewBag

            ViewData["adarsh"] = "Akash Mishra Pawad";
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
