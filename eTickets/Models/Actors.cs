using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actors
    {
        //Unique Identifier
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture URL")]
        public string? ProfilePictureURL { get; set; }
        [Display(Name = "Full Name")]
        public string? FullName { get; set; }
        [Display(Name = "Biography")]
        public string? Bio { get; set; }

        //Relationships
        public List<Actors_Movies>? Actors_Movies { get; set; }
    }
}