using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Movies.Models;
using Movies.ViewModels;

namespace Movies.Controllers
{
    public class MoviesController : Controller
    {
        public List<Movie> movie = new List<Movie>()
        {
            new Movie
            {
                Id = 1,
                Name = "Titanic",
                Date = new DateTime(1997, 12, 19),
                Actors = new List<string> { "Leonardo", "Kate" },
                Description = "A seventeen-year-old aristocrat falls in love with a kind but poor artist aboard the luxurious, ill-fated R.M.S. Titanic.",
                Directors = new List<string> { "James Cameron" },
                Genre = "Drama/Romance"
            },
            new Movie
            {
                Id = 2,
                Name = "No Country for Old Men",
                Date = new DateTime(2007, 11, 21),
                Actors = new List<string> { "Tommy Lee Jones", "Javier Bardmen" },
                Description = "Violence and mayhem ensue after a hunter stumbles upon a drug deal " +
                "gone wrong and more than two million dollars in cash near the Rio Grande.",
                Directors = new List<string> { "Joel Coen", "Ethan Coen" },
                Genre = "Crime/Thriller"
            }
        };
            // GET: Movies/Random
        public IActionResult Random()
        {
            var customers = new List<Customers>
           {
               new Customers { Name = "John Smith"},
               new Customers { Name = "Mary Williams"},
               new Customers { Name = "Jerry Smith"},
               new Customers { Name = "Billy Bob"}
           };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie[0],
                Customers = customers
            };

            return View(viewModel);
        }
        public ActionResult Edit(int id)
        {
            return Content("id: " + id);
        }
        //Movies/Actors
        public ActionResult Actors(int id)
        {
            return View(movie);
        }
        //movies
        //Index is the default action (movies) for this controller
        //We want to pass in the specified page num, use 1 if not listed
        //if sort is not specified then sort by name
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "name";

            return View(movie);
            //return Content(String.Format("pageIndex={0)&sortBy={1}", pageIndex, sortBy));
        }
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}