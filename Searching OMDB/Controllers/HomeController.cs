using Microsoft.AspNetCore.Mvc;
using Searching_OMDB.Models;
using System.Diagnostics;

namespace Searching_OMDB.Controllers
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
            return View();
        }
        public IActionResult MovieSearch()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult MovieSearch(string name)
        {
            return View(MovieDAL.GetMovieModel(name));
        }
        public IActionResult MovieNight()
        {
            return View();
        }
        [HttpPost]
        public IActionResult MovieNight(string name1, string name2, string name3)
        {
            List<MovieModel> movieNight = new List<MovieModel>();
            movieNight.Add(MovieDAL.GetMovieModel(name1));
            movieNight.Add(MovieDAL.GetMovieModel(name2));
            movieNight.Add(MovieDAL.GetMovieModel(name3));
            return View(movieNight);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}