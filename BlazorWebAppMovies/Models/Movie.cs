using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace BlazorWebAppMovies.Models
{
    public class Movie
    {

        public int Id { get; set; }

        [Required]
        [StringLength(60, MinimumLength =2)]
        public string? Title { get; set; }

        public DateOnly ReleaseDate { get; set; }

        [Required]
        [StringLength(30)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z()\s-]*$")]
        public string? Genre { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        [Range(0, 100)]
        public decimal Price { get; set; }

        [Required]
        [RegularExpression(@"^(G|PG|PG-13|R|NC-17)$")]
        public string? Rating { get; set; }
    }
}
