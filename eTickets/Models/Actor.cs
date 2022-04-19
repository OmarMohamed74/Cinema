using eTickets.Models.Data.Repositories;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor:IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Full Name")]
        [Required(ErrorMessage ="Please Enter Your Fulll Name")]
        [StringLength(20,MinimumLength =3,ErrorMessage ="Please Enter Number Between 3 to 20 Chars")]

        public string FullName { get; set; }

        [Display(Name ="ProfileURL")]
        [Required(ErrorMessage = "Please Enter Your Profile URL")]
        public string ProfilePictureURL { get; set; }

        [Display(Name ="Biography")]
        [Required(ErrorMessage = "Please Enter Your Bio")]
        
        public string Bio { get; set; }

        //Relations

        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
