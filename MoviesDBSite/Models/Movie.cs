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

		[StringLength(60, MinimumLength = 3)]
		[Required]
		public string Name { get; set; }

		[Display(Name = "Release Date")]
		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:dd--MM-yyyy}", ApplyFormatInEditMode = true)]
		public DateTime ReleaseDate { get; set; }


		[Required]
		public int DirectorId{ get; set; }

		public virtual ICollection<Character> Characters { get; set; }

	}
	
}