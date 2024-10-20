using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using VievStart_In_Core.Models;

namespace layoutCSHTML_Core.Controllers;

[Route("[controller]")]
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    [Route("")]
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    [Route("privacy")]
    public IActionResult Privacy()
    {
        return View();
    }

    [HttpGet]
    [Route("home")]
    public IActionResult Home()
    {
        return View();
    }

    [HttpGet]
    [Route("about")]
    public IActionResult About()
    {
        return View();
    }

    [HttpGet]
    [Route("contactus")]
    public IActionResult Contactus()
    {
        return View();
    }

    [HttpGet]
    [Route("more")]
    public IActionResult More()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
