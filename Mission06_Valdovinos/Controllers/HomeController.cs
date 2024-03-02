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
            ViewBag.Categories = _context.Categories.ToList();

            return View();
        }

        [HttpPost]

        public IActionResult MovieForm(Application response)
        {
            _context.Application.Add(response); //add to the database
            _context.SaveChanges();

            return View("FormConfirmation", response);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var recordToEdit = _context.Application
                .Single(x => x.MovieID == id); 

            ViewBag.Categories = _context.Categories.ToList();

            return View("MovieForm", recordToEdit);
        }
        [HttpPost]

        public IActionResult Edit(Application updatedInfo)
        {
            _context.Update(updatedInfo);
            _context.SaveChanges();

            return RedirectToAction("Index"); //go back to the table so it can save

        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var recordToDelete = _context.Application
                .Single(x => x.MovieID == id);

            return View(recordToDelete);
        }
        [HttpPost]

        public IActionResult Delete(Application deletedInfo)
        {
            _context.Application.Remove(deletedInfo);
            _context.SaveChanges();

            return RedirectToAction("Index");

        }
    }
}
