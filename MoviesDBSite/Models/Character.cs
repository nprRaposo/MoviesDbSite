using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoviesDBSite.Models
{
	public class Character
	{
		public int Id { get; set; }
		public int MovieId { get; set; }
		public int ActorId { get; set; }
		public string Name { get; set; }

		public virtual Actor Actor{get; set;}
		public virtual Movie Movie { get; set; }

	}
}