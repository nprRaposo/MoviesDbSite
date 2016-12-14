using System;
using System.Collections.Generic;
using System.Linq;

namespace Movies.DataBase.Entities
{
	public class Actor
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }


		public virtual ICollection<Character> Characters { get; set; }
	}
}