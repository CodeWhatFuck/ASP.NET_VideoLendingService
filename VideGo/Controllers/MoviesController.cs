using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VideGo.Models;
using VideGo.ViewModels;

namespace VideGo.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {

            var movie = new Movie() { Name = "Alien: Covenant" };

            var customers = new List<Customer>
            {
                new Customer { Name = "Brian" },
                new Customer { Name = "Todd" }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

        public ActionResult Edit(int id)
        {
            return Content("id = " + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "name";

            return Content(String.Format("pageIndex={0}&sortBy{1}",pageIndex, sortBy));
        }

        [Route("movies/released/{year}/{month}")]
        public ActionResult byReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}