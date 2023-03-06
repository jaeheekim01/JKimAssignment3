using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace JKimAssignment3.Models
{
    public class Actor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        [Url]
        public string? ImdbLink { get; set; }
        public byte[]? ActorImage { get; set; }

        [ForeignKey("Movie")]
        public int? MovieId { get; set; }
        public Movie? Movie { get; set; }
    }
}
