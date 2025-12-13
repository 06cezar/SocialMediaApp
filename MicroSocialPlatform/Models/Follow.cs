namespace MicroSocialPlatform.Models
{
    public class Follow
    {
        public int Id { get; set; }

        // un follow are un follower si un followee (user-ul care urmareste si user-ul urmarit)
        public int? FollowerId { get; set; }
        public virtual ApplicationUser? Follower { get; set; }
        public int? FolloweeId { get; set; }
        public virtual ApplicationUser? Followee { get; set; }
    }
}
