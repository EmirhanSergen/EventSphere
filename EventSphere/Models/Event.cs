using System.ComponentModel.DataAnnotations;

namespace EventSphere.Models
{
    public class Event
    {
        [Key]
        public int Id { get; set; }

        public int UserId { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [StringLength(100, MinimumLength = 30)]
        public string ShortDesc { get; set; } = string.Empty;
        
        [Required]
        [StringLength(400, MinimumLength = 80)]
        public string LongDesc { get; set; } = string.Empty;
        
        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        public string Location { get; set; } = string.Empty;
        
        public int CategoryId { get; set; }

    }
}
