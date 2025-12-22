using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using OnlineStore.Data.Models.Enum;
using static OnlineStore.Common.EntityValidation.AuditLog;

namespace OnlineStore.Data.Models
{
    public class AuditLog
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(User))]
        public int? UserId { get; set; }
        public virtual User? User { get; set; }

        [Required]
        public AuditAction Action { get; set; }

        [Required]
        public string Meta { get; set; } = null!;

        [Required]
        public DateTime CreatedAt { get; set; }


    }
}
