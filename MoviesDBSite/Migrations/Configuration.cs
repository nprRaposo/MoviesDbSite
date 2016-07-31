namespace MoviesDBSite.Migrations
{
	using MoviesDBSite.DAL;
	using MoviesDBSite.Models;
	using System;
	using System.Data.Entity;
	using System.Data.Entity.Migrations;
	using System.Linq;

	internal sealed class Configuration : DbMigrationsConfiguration<MovieDbContext>
	{
		public Configuration()
		{
			AutomaticMigrationsEnabled = false;
		}

		protected override void Seed(MovieDbContext context)
		{
			
		}
	}
}
