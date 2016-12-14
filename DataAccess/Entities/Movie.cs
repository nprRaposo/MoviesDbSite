using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movies.DataBase.Entities
{
	public class Movie
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public DateTime ReleaseDate { get; set; }


		public int DirectorId{ get; set; }

		public virtual ICollection<Character> Characters { get; set; }

	}
	
}