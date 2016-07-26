namespace MoviesDBSite.Migrations
{
	using MoviesDBSite.Models;
	using System;
	using System.Data.Entity;
	using System.Data.Entity.Migrations;
	using System.Linq;

	internal sealed class Configuration : DbMigrationsConfiguration<MoviesDBSite.Models.MovieDbContext>
	{
		public Configuration()
		{
			AutomaticMigrationsEnabled = false;
		}

		protected override void Seed(MoviesDBSite.Models.MovieDbContext context)
		{
			context.Movies.AddOrUpdate(i => i.Name,
				   new Movie
				   {
					   Name = "When Harry Met Sally",
					   ReleaseDate = DateTime.Parse("1989-1-11"),
					   Director = "Leo di Caprio"
				   },

					new Movie
					{
						Name = "Ghostbusters ",
						ReleaseDate = DateTime.Parse("1984-3-13"),
						Director = "Leo di Caprio"
					},

					new Movie
					{
						Name = "Ghostbusters 2",
						ReleaseDate = DateTime.Parse("1986-2-23"),
						Director = "Leo di Caprio"
					},

				  new Movie
				  {
					  Name = "Rio Bravo",
					  ReleaseDate = DateTime.Parse("1959-4-15"),
					  Director = "Leo di Caprio"
				  }
			);
		}
	}
}
