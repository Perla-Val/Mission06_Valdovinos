using Microsoft.AspNetCore.Mvc;
using Mission06_Valdovinos.Models;
using System.Diagnostics;

namespace Mission06_Valdovinos.Controllers
{
    public class HomeController : Controller
    {
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
            return View("FormConfirmation", response);
        }


    }
}
