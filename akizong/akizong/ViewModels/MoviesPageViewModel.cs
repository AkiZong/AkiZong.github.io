using akizong.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace akizong.ViewModels
{
    public class MoviesPageViewModel
    {
        public Movie Movie { get; set; }
        public List<Movie> Movies { get; set; }
    }
}
