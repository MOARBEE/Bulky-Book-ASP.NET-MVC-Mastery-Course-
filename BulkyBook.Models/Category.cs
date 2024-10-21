using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyBook.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [DisplayName("Display Order")]    //So when you display in the view (on the actual screen the users are looking at, it shows as DisplayOrder, so this is how you rename it to show as Display Order on the screen for the users to see.
        [Range(1, 100,ErrorMessage ="Display Order must be between 1 and a 100 only!!")]
        public int DisplayOrder { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
