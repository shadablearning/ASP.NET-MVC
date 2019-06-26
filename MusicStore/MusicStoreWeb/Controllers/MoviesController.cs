using MusicStoreWeb.Models;
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
            //return View(movie);
            // return Content(movie.Name);
            //return HttpNotFound();
            //return new EmptyResult();
            return RedirectToAction("Index","Home",new { page=1,sortBy="Name"});
        }

        //2
        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        //public ActionResult Edit(int movieId)
        //{
        //    return Content("id=" + movieId);
        //}
    }
}