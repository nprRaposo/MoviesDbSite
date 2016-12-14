using Movies.DataBase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Movies.Services;

namespace Movies.Services.Presentation
{
    public class MovieServicesPresentation
    {
		public static List<Movie> GetMovies()
		{
			return MovieServices.Get();
		}
    }
}
