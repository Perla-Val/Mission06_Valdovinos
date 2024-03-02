using Microsoft.AspNetCore.Mvc;
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
            return View();
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


    }
}
