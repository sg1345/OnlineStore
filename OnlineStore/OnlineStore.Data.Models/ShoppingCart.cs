using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OnlineStore.Data.Models
{
    public class ShoppingCart
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(User))]
        public int? UserId { get; set; }
        public virtual User? User { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }
        
        public virtual ICollection<CartItem> CartItems { get; set; } = new HashSet<CartItem>();
    }
}
