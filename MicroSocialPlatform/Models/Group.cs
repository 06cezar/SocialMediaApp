using System.ComponentModel.DataAnnotations;

namespace MicroSocialPlatform.Models
{
    public class Group
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "This group must have a name!")]
        public string Name { get; set; }
        public string Description { get; set; }

        /// un group este creat de un user (admin)
        public int? AdminId { get; set; }
        // proprietatea de navigare catre ApplicationUser (adminul grupului)
        public virtual ApplicationUser? Admin { get; set; }

        public DateTime CreatedAt { get; set; }

        // relatia many-to-many dintre ApplicationUser si Group
        public virtual ICollection<Member> Members { get; set; } = new List<Member>();

    }
}
