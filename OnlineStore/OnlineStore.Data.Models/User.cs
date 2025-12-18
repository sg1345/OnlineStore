using System.ComponentModel.DataAnnotations;
using static OnlineStore.Common.EntityValidation.User;

namespace OnlineStore.Data.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(UserNameMaxLength)]
        public string UserName { get; set; } = null!;

        [Required]
        [EmailAddress]
        [MaxLength(EmailMaxLength)]
        public string Email { get; set; } = null!;

        [Required]
        public string PasswordHash { get; set; } = null!;

        [Required]
        [MaxLength(FirstNameMaxLength)]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(LastNameMaxLength)]
        public string LastName { get; set; } = null!;

        [Required]
        public bool IsAdmin { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }
        [Required]
        public DateTime UpdatedAt { get; set; }

        public virtual ICollection<Order> Orders { get; set; } = new HashSet<Order>();
        public virtual ICollection<Address> Addresses { get; set; } = new HashSet<Address>();
        public virtual ICollection<Review> Reviews { get; set; } = new HashSet<Review>();
        public virtual ShoppingCart? ShoppingCart { get; set; }
        public virtual ICollection<AuditLog> AuditLogs { get; set; } = new HashSet<AuditLog>();
    }

}
