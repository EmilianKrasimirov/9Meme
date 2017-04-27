namespace Ripoff_Of_Kenov.Migrations
{
    using Data;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<Ripoff_Of_Kenov.Data.PostsDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "Ripoff_Of_Kenov.Data.PostsDbContext";
        }

        protected override void Seed(Ripoff_Of_Kenov.Data.PostsDbContext context)
        {
            if (context.Posts.Any())
            {
                return;
            }

            var user = context.Users.FirstOrDefault();

            if (user == null)
            {
                return;
            }

            context.Posts.Add(new Post
            {
                Title = "Kappa",
                Description = "This is the ultimate Meme!",
                ImageUrl = "http://i3.kym-cdn.com/photos/images/newsfeed/000/925/494/218.png_large",
                OwnerId = user.Id
            });

            context.Posts.Add(new Post
            {
                Title = "Troll",
                Description = "U mad bro?",
                ImageUrl = "https://imgflip.com/s/meme/Troll-Face.jpg",
                OwnerId = user.Id
            });

            context.Posts.Add(new Post
            {
                Title = "NO GOD PLEASE NO!",
                Description = "When you code for 8 hours without saving and your computer crashes",
                ImageUrl = "https://thetab.com/blogs.dir/91/files/2017/01/maxresdefault-1.jpg",
                OwnerId = user.Id
            });

            context.Posts.Add(new Post
            {
                Title = "KappaPride",
                Description = "HA!GAYYYYYYYYYYY",
                ImageUrl = "http://vignette3.wikia.nocookie.net/hatmaster/images/d/df/Kappapride.png/revision/latest?cb=20160319015547",
                OwnerId = user.Id
            });
        }
    }
}
