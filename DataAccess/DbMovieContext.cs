using Movies.DataBase.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MoviesDBSite.DAL
{
	public class MovieDbContext : DbContext
	{
		public MovieDbContext()
			: base("MovieDbContext")
        {
        }

		public static DbSet<Movie> Movies { get; set; }
		public static DbSet<Character> Characters { get; set; }
		public static DbSet<Actor> Actors { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
		}
	}
}