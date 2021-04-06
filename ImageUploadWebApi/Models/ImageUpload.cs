using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace ImageUploadWebApi.Models
{
    public class ImageUpload
    {
        [Required(ErrorMessage = "Image upload is required, please select a file")]
        public IFormFile Image { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
    }
}
