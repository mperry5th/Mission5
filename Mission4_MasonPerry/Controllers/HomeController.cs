using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        public IActionResult ViewMovies()
        {
            ViewBag.Category = _context.categories.ToList();

            var movies = _context.movies
                .Include(x => x.Category)
                .ToList();
            return View(movies);
        }
        
        [HttpGet]
        public IActionResult addMovie()
        {
            ViewBag.Category = _context.categories.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult addMovie(Movies m)
        {
            if (ModelState.IsValid)
            { 
                _context.Add(m);
                _context.SaveChanges();
                return View("Confirmation", m);
            }
            else
            {
                ViewBag.Category = _context.categories.ToList();
                return View(m);
            }
        }

        [HttpGet]
        public IActionResult Edit(int movieid)
        {
            ViewBag.Category = _context.categories.ToList();
            var movie = _context.movies.Single(x => x.MovieId == movieid);
            return View("addMovie", movie);
        }

        [HttpPost]
        public IActionResult Edit(Movies mov)
        {
            _context.Update(mov);
            _context.SaveChanges();
            return RedirectToAction("ViewMovies");
        }

        [HttpGet]
        public IActionResult Delete(int movieid)
        {
            var movie = _context.movies.Single(x => x.MovieId == movieid);
            return View(movie);
        }
        [HttpPost]
        public IActionResult Delete(Movies m)
        {
            _context.movies.Remove(m);
            _context.SaveChanges();
            return RedirectToAction("ViewMovies");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
