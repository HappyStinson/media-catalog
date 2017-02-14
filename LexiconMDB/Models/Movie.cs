using System.ComponentModel.DataAnnotations;

namespace LexiconMDB.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        public int? Length { get; set; }
        public string Genre { get; set; }
        public int? AgeLimit { get; set; }
        public int? MetaScore { get; set; }

    }
}