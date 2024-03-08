using CarWorkshop.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CarWorkshop.MVC.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            var model = new List<Person>()
            {
                new Person()
                {
                    FirstName="Lukasz",
                    LastName="Kusmierz"
                },
                new Person()
                {
                    FirstName="James",
                    LastName="Bond"
                }
            };

            return View(model);
        }

        public IActionResult About()
        {
            var model = new List<About>()
            {
                new About()
                {
                    Title="Pan Tadeusz",
                    Description="O Tadeuszu co nie kochał Telimeny",
                    Tags=new[] {"romantyzm","wiersz"}
                },
                new About()
                {
                    Title="Potop",
                    Description="Najzd szwedów",
                    Tags=new[] {"powieść", "militarne"}
                }
            };
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
