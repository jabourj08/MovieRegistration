using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieRegistration.Models;

namespace MovieRegistration.Controllers
{
    public class MovieController : Controller
    {
        List<Movie> favoritesList = new List<Movie>();
        //List<Movie> myList = HttpContext.Session.GetObjectFromJson<List<Movie>>("asdf") ?? new List<Movie>();

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

        public IActionResult SaveMovieToFavorites(Movie movie)
        {
            //retrieving the Book List Session. If the booklist session doesnt exist, the string bookListJSON will be set to "EmptySession"
            string movieListJSON = HttpContext.Session.GetString("MovieListSession") ?? "EmptySession";
            if (movieListJSON != "EmptySession")
            {
                //using System.Text.Json;
                //This turns the string of JSON into List of individual Book Objects
                favoritesList = JsonSerializer.Deserialize<List<Movie>>(movieListJSON);
            }
            //Update the booklist by adding the book from the form
            favoritesList.Add(movie);

            //Update/Save the new book into the session
            //Turns out List of objects (books) into a string that the session can keep
            movieListJSON = JsonSerializer.Serialize(favoritesList);
            //sets the session to the updated JSON
            HttpContext.Session.SetString("MovieListSession", movieListJSON);

            //TempData["myData"] = favoritesList;

            return View("ShowFavoriteMovies", favoritesList);
        }

        public IActionResult ShowFavoriteMovies()
        {
            return View();
        }
    }
}
