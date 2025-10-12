using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movies.Models {
	public class Movie {
		public int Id { get; set; }

		[Required]
		[StringLength(32, MinimumLength = 2)]
		[DisplayName("Название")]
		public string Title { get; set; }

		[Range(typeof(DateOnly), "1888-10-14", "2032-12-31")]
		[DisplayName("Дата выхода")]
		public DateOnly ReleaseDate { get; set; }

		[RegularExpression(@"^[A-Za-z\s]+[A-Z\s]*$")]
		[DisplayName("Жанр")]
		public string? Genre { get; set; }
		[DisplayName("Цена")]
		public decimal? Price { get; set; }
	}
}
