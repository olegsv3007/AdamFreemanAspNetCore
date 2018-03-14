using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cities.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cities.Controllers
{
    public class HomeController : Controller
    {
        private IRepository repository;

        public HomeController(IRepository repo)
        {
            repository = repo;
        }

        public ViewResult Index() => View(repository.Cities);
        public ViewResult Create() => View();

        [HttpPost]
        public IActionResult Create(City city)
        {
            repository.AddCity(city);
            return RedirectToAction(nameof(Index));
        }
    }
}