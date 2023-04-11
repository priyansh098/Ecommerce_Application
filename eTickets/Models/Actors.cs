using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actors
    {
        //Unique Identifier
        [Key]
        public int Id { get; set; }

        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }

        //Relationships
        public List<Actors_Movies> Actors_Movies { get; set; }
    }
}