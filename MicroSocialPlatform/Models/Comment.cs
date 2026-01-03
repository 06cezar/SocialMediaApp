using System.ComponentModel.DataAnnotations;

namespace MicroSocialPlatform.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime? UpdatedAt { get; set; }

        // un comentariu apartine unui singur user
        public string UserId { get; set; }
        public virtual ApplicationUser? User { get; set; }

        // un comentariu apartine unui singur post
        public int PostId { get; set; }
        public virtual Post? Post { get; set; }
    }
}
