using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission4_MasonPerry.Models;

namespace Mission4_MasonPerry.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private MovieContext _context { get; set; }

        public HomeController(ILogger<HomeController> logger, MovieContext lol)
        {
            _logger = logger;
            _context = lol;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Podcasts()
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult addMovie()
        {
            return View();
        }

        [HttpPost]
        public IActionResult addMovie(Movies m)
        {
            _context.Add(m);
            _context.SaveChanges();
            return View("Confirmation", m);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
