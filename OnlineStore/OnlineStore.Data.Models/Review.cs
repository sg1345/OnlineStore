using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using static OnlineStore.Common.EntityValidation.Review;

namespace OnlineStore.Data.Models
{
    public class Review
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; } = null!;

        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public virtual User User { get; set; } = null!;

        [Required]
        public int Rating { get; set; }

        [Required]
        [MaxLength(TitleMaxLength)]
        public string Title { get; set; } = null!;

        [Required]
        public string Body { get; set; } = null!;

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public bool IsApproved { get; set; }

        
        
    }
}
