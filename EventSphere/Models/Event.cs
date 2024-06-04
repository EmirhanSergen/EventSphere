namespace EventSphere.Models
{
    public class Event
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; } = string.Empty; 
        public string ShortDesc { get; set; } = string.Empty;
        public string LongDesc { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public string Location { get; set; } = string.Empty;
        public int CategoryId { get; set; }

    }
}
