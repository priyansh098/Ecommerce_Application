using eTickets.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets.Models
{
    public class Movies
    {
        //Unique Identifier
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double Price { get; set; }
        public MovieCategory MovieCategory { get; set; }
        public string ImageURL { get; set; }

        //Relationships
        public List<Actors_Movies> Actors_Movies { get; set; }

        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinemas Cinemas { get; set; }

        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producers Producers { get; set; }
    }
}