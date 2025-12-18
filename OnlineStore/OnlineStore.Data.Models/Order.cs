using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using static OnlineStore.Common.EntityValidation.Order;

namespace OnlineStore.Data.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(User))]
        public int? UserId { get; set; }
        public virtual User? User { get; set; }

        [Required]
        [MaxLength(OrderNumberMaxLength)]
        public string OrderNumber { get; set; } = null!;


        //I can make it Enum
        [Required]
        [MaxLength(StatusMaxLength)]
        public string Status { get; set; } = null!;

        [Required]
        [Column(TypeName = TotalAmountColumnType)]
        public decimal TotalAmount { get; set; }

        [Required]
        [MaxLength(CurrencyMaxLength)]
        public string Currency { get; set; } = null!;

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public DateTime UpdatedAt { get; set; }


        public virtual Payment? Payment { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; } = new HashSet<OrderItem>();
    }
}
