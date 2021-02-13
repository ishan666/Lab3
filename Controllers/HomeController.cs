using Microsoft.AspNetCore.Mvc;
using Lab3.Models;

namespace Lab3.Controllers

{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        public IActionResult Razor()
        {
            return View();
        }

        public IActionResult Count(Person person)
        {
            return View(person);
        }

        public IActionResult CreatePerson()
        {
            return View();
        }

        public IActionResult DisplayPerson(Person person)
        {
            return View(person);
        }
    }
}
