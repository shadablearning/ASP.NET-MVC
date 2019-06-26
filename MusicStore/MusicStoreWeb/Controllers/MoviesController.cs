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
        public ActionResult Index()
        {            
            return View();
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
    }
}