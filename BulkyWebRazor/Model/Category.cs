using System.ComponentModel.DataAnnotations;

namespace BulkyWebRazor.Model
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Category Name")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Display Order is required")]
        [Display(Name = "Display Order")]
        [Range(1, 100, ErrorMessage = "Display Order must be between 1 and 100")]
        public int DisplayOrder { get; set; }

        [Required(ErrorMessage = "Description is required")]
        [Display(Name = "Description")]
        [StringLength(200, MinimumLength = 4, ErrorMessage = "Description must be between 4 and 200 characters")]
        public string Description { get; set; }
    }
}
