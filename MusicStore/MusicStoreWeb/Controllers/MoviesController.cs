using MusicStoreWeb.Models;
using MusicStoreWeb.ViewModels;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicStoreWeb.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        //3
        //movies
        public ActionResult Index(int? pageIndex,string sortBy)
        {
            var movies = _context.Movies.Include(m => m.Genre).ToList();

            return View(movies);
            //return View();
        }

        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);

            if (movie == null)
                return HttpNotFound();

            return View(movie);

        }

        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name="Shrek!"};

            var customers = new List<Customer>
            {
                new Customer{Name="Customer 1"},
                new Customer{Name="Customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers

            };

            //var ViewResult = new ViewResult();

            //ViewResult.ViewData.Model

            return View(viewModel);

        }

        //2
        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year,int month)
        {
            return Content(year+"/"+month);
        }

        //public ActionResult Edit(int movieId)
        //{
        //    return Content("id=" + movieId);
        //}
    }
}