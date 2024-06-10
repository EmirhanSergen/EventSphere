using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventSphere.Models
{
    public class EventCategory
    {
        [Key, Column(Order = 0)]
        public int EventId { get; set; }
        public Event Event { get; set; } = default!;  // Navigation property

        [Key, Column(Order = 1)]
        public int CategoryId { get; set; }
        public Category Category { get; set; } = default!;  // Navigation property
    }
}
