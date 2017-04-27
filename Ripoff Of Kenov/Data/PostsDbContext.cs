namespace Ripoff_Of_Kenov.Data
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.Data.Entity;

    public class PostsDbContext : IdentityDbContext<User>
    {
        public PostsDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public virtual IDbSet<Post> Posts { get; set; }

        public static PostsDbContext Create()
        {
            return new PostsDbContext();
        }
    }
}