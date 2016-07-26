using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MoviesDBSite.Models
{
	public class Movie
	{
		public int Id { get; set; }
		public string Name { get; set; }

		[Display(Name = "Release Date")]
		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:dd--MM-yyyy}", ApplyFormatInEditMode = true)]
		public DateTime ReleaseDate { get; set; }

		public string Director { get; set; }

	}

	public class MovieDbContext : DbContext
	{
		public DbSet<Movie> Movies { get; set; }
	}
}