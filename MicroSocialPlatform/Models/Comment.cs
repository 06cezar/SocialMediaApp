namespace MicroSocialPlatform.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }

        // un comentariu apartine unui singur user
        public int? UserId { get; set; }
        public virtual ApplicationUser? User { get; set; }

        // un comentariu apartine unui singur post
        public int? PostId { get; set; }
        public virtual Post? Post { get; set; }
    }
}
