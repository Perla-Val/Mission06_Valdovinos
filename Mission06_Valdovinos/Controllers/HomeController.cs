using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mission06_Valdovinos.Models;
using System.Diagnostics;

namespace Mission06_Valdovinos.Controllers
{
    public class HomeController : Controller
    {

        private MovieFormContext _context;
        public HomeController(MovieFormContext temp) //connstructure
        {
            _context = temp;
        }

        public IActionResult Index()
        {
            var application = _context.Application
                .OrderBy(x => x.Title).ToList();

            return View(application);
        }

        public IActionResult About()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieForm()
        {
            return View();
        }

        [HttpPost]

        public IActionResult MovieForm(Application response)
        {
            _context.Application.Add(response); //add to the database
            _context.SaveChanges();

            return View("FormConfirmation", response);
        }

        public IActionResult MovieList ()
        {
            var application = _context.Application
                .Where(x => x.Edited == false)
                .OrderBy(x => x.Title).ToList();

            return View();
        }
    }
}
