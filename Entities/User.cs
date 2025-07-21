using Between_The_Covers___Backend.Common;

namespace Between_The_Covers___Backend.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
        public Roles.UserRole Role { get; set; }

    }
}
