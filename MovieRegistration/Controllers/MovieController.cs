using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieRegistration.Models;

namespace MovieRegistration.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult MovieRegistration()
        {
            return View();
        }

        public IActionResult DisplayMovie(Movie movie)
        {
            if (ModelState.IsValid)
            {
                //movie.Actors.Add()
                return View(movie);
            }
            else
            {
                return View("MovieRegistration", movie);
            }
        }
    }
}
