namespace Ripoff_Of_Kenov.Controllers
{
    using Data;
    using Microsoft.AspNet.Identity;
    using Models.Posts;
    using System.Web.Mvc;

    public class PostsController : Controller
    {
        [Authorize]
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public ActionResult Create(CreatePostModel postModel )
        {
            if(postModel != null && this.ModelState.IsValid)
            {
                var ownerId = this.User.Identity.GetUserId();

                var post = new Post
                {
                    Title = postModel.Title,
                    Description = postModel.Description,
                    ImageUrl = postModel.ImageUrl,
                    OwnerId = ownerId
                };

                var db = new PostsDbContext();
                db.Posts.Add(post);
                db.SaveChanges();

                return RedirectToAction("Details", new { id = post.Id });
            }

            return View(postModel);
        }
    }
}