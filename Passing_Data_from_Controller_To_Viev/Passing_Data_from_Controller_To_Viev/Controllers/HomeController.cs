using Microsoft.AspNetCore.Mvc;
using Passing_Data_from_Controller_To_Viev.Models;
using System.Diagnostics;

namespace Passing_Data_from_Controller_To_Viev.Controllers
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
            ViewData["name"] = "akash Mishra";
            ViewData["age"] = 22;
            ViewData["date"]= DateTime.Now.ToLongDateString();

            //passing the array in he view data

            string[] arr = { "akash", "vishal", "naveen", "akhilesh" };
            ViewData["array"] = arr;

            ViewData["Language"] = new List<string>()
            {
                "C",
                "C++",
                "C#",
                "Python",
                "JavaScript",
                "Asp.Net",
                "React Js",
                "Next Js",
                "Ms Sql Server",
                "My sql",
                "Mongo Db"
            };
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
