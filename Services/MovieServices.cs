using Movies.DataBase.Entities;
using MoviesDBSite.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Services
{
    public class MovieServices
    {

		public static List<Movie> Get()
		{
			return MovieDbContext.Movies.ToList();
		}
	}
}
