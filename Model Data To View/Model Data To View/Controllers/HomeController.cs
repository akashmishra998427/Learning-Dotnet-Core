using Microsoft.AspNetCore.Mvc;
using Model_Data_To_View.Models;
using System.Diagnostics;

namespace Model_Data_To_View.Controllers
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
            //Employee employee = new Employee()
            //{
            //    Designation = "Manager",
            //    EmpName="Akash Mishra",
            //    Salary=30000,
            //    EmpID = 103
            //};

            //ViewData["Employee"] = employee;
            //ViewBag.employee= employee;
            //TempData["Employe"] = employee;


            // Create a list of 20 Employee objects
            List<Employee> employees = new List<Employee>()
            {
                new Employee() { EmpID = 101, EmpName = "John Smith", Designation = "Manager", Salary = 50000 },
                new Employee() { EmpID = 102, EmpName = "Jane Doe", Designation = "Developer", Salary = 40000 },
                new Employee() { EmpID = 103, EmpName = "Akash Mishra", Designation = "Manager", Salary = 30000 },
                new Employee() { EmpID = 104, EmpName = "Maria Garcia", Designation = "HR", Salary = 35000 },
                new Employee() { EmpID = 105, EmpName = "Robert Johnson", Designation = "Sales Executive", Salary = 32000 },
                new Employee() { EmpID = 106, EmpName = "Emily Brown", Designation = "Marketing Manager", Salary = 45000 },
                new Employee() { EmpID = 107, EmpName = "Michael White", Designation = "CTO", Salary = 70000 },
                new Employee() { EmpID = 108, EmpName = "Sophia Green", Designation = "Lead Designer", Salary = 38000 },
                new Employee() { EmpID = 109, EmpName = "James Taylor", Designation = "Support Engineer", Salary = 28000 },
                new Employee() { EmpID = 110, EmpName = "Isabella Miller", Designation = "Business Analyst", Salary = 41000 },
                new Employee() { EmpID = 111, EmpName = "David Wilson", Designation = "Developer", Salary = 39000 },
                new Employee() { EmpID = 112, EmpName = "Olivia Lee", Designation = "Marketing Specialist", Salary = 37000 },
                new Employee() { EmpID = 113, EmpName = "William Harris", Designation = "Accountant", Salary = 33000 },
                new Employee() { EmpID = 114, EmpName = "Mason Clark", Designation = "Team Leader", Salary = 48000 },
                new Employee() { EmpID = 115, EmpName = "Charlotte Lewis", Designation = "Recruiter", Salary = 34000 },
                new Employee() { EmpID = 116, EmpName = "Henry Walker", Designation = "DevOps Engineer", Salary = 46000 },
                new Employee() { EmpID = 117, EmpName = "Amelia Hill", Designation = "Product Manager", Salary = 55000 },
                new Employee() { EmpID = 118, EmpName = "Lucas Adams", Designation = "Software Architect", Salary = 60000 },
                new Employee() { EmpID = 119, EmpName = "Evelyn Carter", Designation = "Consultant", Salary = 53000 },
                new Employee() { EmpID = 120, EmpName = "Elijah Turner", Designation = "Sales Manager", Salary = 43000 },
            };

            // Pass the list to the view using ViewData, ViewBag, and TempData
            ViewData["Employees"] = employees;
            ViewBag.employees = employees;
            TempData["Employees"] = employees;

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
