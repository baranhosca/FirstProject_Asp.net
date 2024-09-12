using First_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace First_Project.Controllers
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

        public IActionResult BooksPage()
        {
            var Bks = new List<Book>()
            {
                new Book() {ID =1,BookName="Nutuk",Writer="Mustafa Kemal ATATURK"},
                new Book() {ID =2,BookName="Caesar",Writer="Christian MEIER" },
                new Book() {ID =3,BookName="Napoleon",Writer="Andrew ROBERTS"},
				new Book() {ID =4,BookName="Alexander The Great",Writer="Jacob ABBOTT"}
			};
            return View(Bks);
        }

        public IActionResult ViewBagUsage()
        {
            ViewBag.value1 = "Hello, Core Lessons are on Going!";
            ViewBag.value2 = "I have a request from you";
            ViewBag.value3 = "Hi, it's the 3. ViewBag!";
            return View(); 
        }

        public IActionResult LayoutPage()
        {
            return View();
        }

        public IActionResult LayoutUsed()
        {
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
