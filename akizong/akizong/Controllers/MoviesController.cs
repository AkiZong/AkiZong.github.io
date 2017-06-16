using System.Runtime.InteropServices.ComTypes;
using akizong.ViewModels;
using akizong.Models;
using System.Security.Cryptography.X509Certificates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace akizong.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult MoviesPage()
        {
            var movie = new Movie { Name = "Aki" };

            var movies = new List<Movie>
            {
                new Movie {Name = "aki1"},
                new Movie {Name = "aki2"}
            };

            var moviesPageViewModel = new MoviesPageViewModel
            {
                Movie = movie,
                Movies = movies
            };

            return View(moviesPageViewModel);
        }
    }
}