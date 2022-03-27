using FilmDepot.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;


namespace FilmDepot.Controllers
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

        public IActionResult Register(RegisterViewModel registerViewModel, ImpossibleYear impossibleYear)
        {
            if (registerViewModel.Year < 1880)
            {
                impossibleYear.errorMessage = "Too Early";
                return View("ImpossibleYear", impossibleYear);
            }
            if(registerViewModel.Year > DateTime.Now.Year)
            {
                impossibleYear.errorMessage = "Too Late";
                return View("ImpossibleYear", impossibleYear);
            }
   
            //do database stuff;
            return View("Result",registerViewModel);
        }

        public IActionResult ImpossibleYear(RegisterViewModel registerViewModel)
        {
            return View(registerViewModel);
        }

        public IActionResult Registration()
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