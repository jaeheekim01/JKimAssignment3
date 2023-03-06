using System.ComponentModel.DataAnnotations;

namespace JKimAssignment3.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [Url]
        public string? ImdbLink { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public byte[]? MovieImage { get; set; }
    }
}
