using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace EventSphere.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        public ICollection<EventCategory> EventCategories { get; set; } = new List<EventCategory>();
    }
}
