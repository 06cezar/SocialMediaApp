using System.ComponentModel.DataAnnotations.Schema;

namespace MicroSocialPlatform.Models
{
    public class Member
    {
        // tabelul asociativ care face legatura intre ApplicationUser si Group
        // un user poate fi membru in mai multe grupuri
        // iar un grup poate avea mai multi membri

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        // cheie primara compusa (Id, UserId, GroupId)
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? GroupId { get; set; }

        public virtual ApplicationUser? User { get; set; }
        public virtual Group? Group { get; set; }
    }
}
