using System.ComponentModel.DataAnnotations;

namespace LexiconMDB.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Display(Name = "Runtime")]
        public int? Length { get; set; }
        public string Genre { get; set; }

        [Display(Name = "Age limit")]
        [Range(0, 18, ErrorMessage = "The age limit must be between 0 and 18 years")]
        public int? AgeLimit { get; set; }

        [Display(Name = "Release year")]
        [Range(1880, 2099, ErrorMessage = "We only store movies released 1880 - 2099 A. D.")]
        public int? ReleaseYear { get; set; }

        [Range(0, 100, ErrorMessage = "Metacritic scores are between 0 - 100")]
        public int? Metascore { get; set; }

        [Display(Name = "IMDb Top 250")]
        public bool IMDbTopRated { get; set; }
    }
}