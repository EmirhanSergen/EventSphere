namespace EventSphere.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public bool isOrganizer { get; set; } = false;
        public string PhoneNumber { get; set; } = string.Empty;


    }
}
