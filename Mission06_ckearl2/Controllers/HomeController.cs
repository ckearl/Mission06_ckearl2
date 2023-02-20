using Microsoft.AspNetCore.Mvc;
using Mission06_ckearl2.Models;

namespace Mission06_ckearl2.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext movieContext { get; set; }

        // Constructor
        public HomeController( MovieContext mcontext)
        {
            movieContext = mcontext;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddMovie()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddMovie(Movie mv)
        {
            movieContext.Add(mv);
            movieContext.SaveChanges();

            return View("AllMovies", mv);
        }

        public IActionResult Podcasts()
        {
            return View();
        }

        public IActionResult BaconSale()
        {
            return Redirect("https://baconsale.com/");
        }

        public IActionResult MovieTable()
        {
            return View();
        }


    }
}
