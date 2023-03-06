using System.ComponentModel.DataAnnotations.Schema;

namespace JKimAssignment3.Models
{
    public class MovieActor
    {
        public int Id { get; set; }

        [ForeignKey("Actor")]
        public int? ActorID { get; set; }
        public Actor? Actor { get; set; }

        [ForeignKey("Movie")]
        public int? MovieID { get; set; }
        public Movie? Movie { get; set; }
    }
}
