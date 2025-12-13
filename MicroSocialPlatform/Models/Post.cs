namespace MicroSocialPlatform.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Content { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }

        // un post apartine unui singur user
        public int? UserId { get; set; }
        public virtual ApplicationUser? User { get; set; }

        // un post poate avea multiple comentarii si reactii
        public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();
        public virtual ICollection<Reaction> Reactions { get; set; } = new List<Reaction>();
    }
}
