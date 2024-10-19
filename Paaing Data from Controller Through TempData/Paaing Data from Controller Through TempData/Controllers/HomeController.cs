using Microsoft.AspNetCore.Mvc;
using Paaing_Data_from_Controller_Through_TempData.Models;
using System.Diagnostics;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewData["data1"] = "View Data";
        ViewBag.data2 = "View Bag";
        TempData["data3"] = "Temp Data";

        TempData["crickter"] = new List<string>()
        {
            "Virat Kholi",
            "Rohit Sharma",
            "MS Dhoni",
            "Sachin Tendulkar"
        };

        // Keep TempData for the next request
        TempData.Keep();
        return View();
    }

    public IActionResult Privacy()
    {
        // Keep TempData for subsequent requests if needed
        TempData.Keep();
        return View();
    }

    public IActionResult About()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
