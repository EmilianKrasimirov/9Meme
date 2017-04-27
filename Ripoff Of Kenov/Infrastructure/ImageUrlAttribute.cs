using System.ComponentModel.DataAnnotations;

namespace Ripoff_Of_Kenov.Infrastructure
{
    public class ImageUrlAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            var imageUrl = value as string;
            if (imageUrl == null)
            {
                return true;
            }

            return imageUrl.EndsWith(".jpg")
                || imageUrl.EndsWith(".png")
                || imageUrl.EndsWith(".png_large")
                || imageUrl.EndsWith(".jpeg")
                || imageUrl.EndsWith(".gif");
        }
    }
}