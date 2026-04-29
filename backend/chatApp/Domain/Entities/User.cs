namespace Domain.Entities

{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public DateTime CreatedAt { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public bool IsOnline { get; set; }
        public DateTime LastSeen { get; set; }

    }
}
