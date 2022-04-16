using eTickets.Models.Data.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [Display(Name="Movie Name")]
        public string  Name { get; set; }
        [Display(Name = "Desctiprion")]
        public string Description { get; set; }
        [Display(Name = "Price")]
        public double Price { get; set; }
        [Display(Name = "Image")]
        public string ImageURL { get; set; }
        [Display(Name = "StartDate")]
        public DateTime StartDate { get; set; }
        [Display(Name = "EndDate")]
        public DateTime EndDate { get; set; }
        [Display(Name = "Category")]
        public MovieCategory MovieCategory { get; set; }

        // Producer Relations
        public int ProducerId { get; set; }

        [ForeignKey("ProducerId")]
        public virtual Producer Producer { get; set; }

        // cinema relation
        public int CinemaId { get; set; }

        [ForeignKey("CinemaId")]
        public virtual Cinema Cinema { get; set; }

        // actor_movie Relations
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
