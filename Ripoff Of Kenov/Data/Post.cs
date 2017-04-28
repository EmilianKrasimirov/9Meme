using Ripoff_Of_Kenov.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace Ripoff_Of_Kenov.Data
{
    public class Post
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(25)]
        public string Title { get; set; }
        [Required]
        [Url]
        [ImageUrl]
        public string ImageUrl { get; set; }
        [MaxLength(50)]
        public string Description { get; set; }
        [Required]
        public string OwnerId { get; set; }

        public virtual User Owner { get; set; }

    }
}