using MusicStoreWeb.Models;
using MusicStoreWeb.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicStoreWeb.Controllers
{
    public class MoviesController : Controller
    {
        //3
        //movies
        public ActionResult Index(int? pageIndex,string sortBy)
        {  
            if(!pageIndex.HasValue)
            {
                pageIndex = 1;
            }

            if(string.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }

            return Content(string.Format("pageInde={0}&sortBy={1}", pageIndex, sortBy));
            //return View();
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