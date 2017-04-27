using Ripoff_Of_Kenov.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace Ripoff_Of_Kenov.Models.Posts
{
    public class CreatePostModel
    {
        [Required]
        [MaxLength(25)]
        public string Title { get; set; }
        [Display(Name = "Meme Url")]
        [Url]
        [ImageUrl]
        [Required]
        public string ImageUrl { get; set; }
        [MaxLength(50)]
        public string Description { get; set; }
    }
}