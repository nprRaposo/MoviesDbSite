using MoviesDBSite.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace MoviesDBSite.DAL
{
	public class MovieDbContext : DbContext
	{
		public MovieDbContext()
			: base("MovieDbContext")
        {
        }

		public DbSet<Movie> Movies { get; set; }
		public DbSet<Character> Characters { get; set; }
		public DbSet<Actor> Actors { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
		}
	}
}