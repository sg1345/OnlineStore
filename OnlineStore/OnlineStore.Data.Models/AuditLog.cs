using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
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

        //possible enum
        [Required]
        [MaxLength(ActionMaxLength)]
        public string Action { get; set; } = null!;

        [Required]
        public string Meta { get; set; } = null!;

        [Required]
        public DateTime CreatedAt { get; set; }


    }
}
