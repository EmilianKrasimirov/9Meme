using Ripoff_Of_Kenov.Data;
using Ripoff_Of_Kenov.Models.Posts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ripoff_Of_Kenov.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var db = new PostsDbContext();

         //  var posts = db.Posts
         //      .OrderByDescending(p => p.Id)
         //      .Take(3)
         //      .Select(p => new HomeIndexPostModel
         //      {
         //          Id = p.Id,
         //          Title = p.Title,
         //          ImageUrl = p.ImageUrl
         //      })
         //      .ToList();

            return View(
                //posts
                );
        }
    }
}