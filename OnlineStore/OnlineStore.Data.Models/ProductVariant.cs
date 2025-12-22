using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using static OnlineStore.Common.EntityValidation.ProductVariant;

namespace OnlineStore.Data.Models
{
    public class ProductVariant
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; } = null!;

        [Required]
        [MaxLength(VariantNameMaxLength)]
        public string VariantName { get; set; } = null!;

        [Required]
        [MaxLength(SkuMaxLength)]
        public string Sku { get; set; } = null!;

        [Column(TypeName = PriceColumnType)]
        public decimal Price { get; set; }


        public virtual Inventory? Inventory { get; set; } 
        public virtual ICollection<OrderItem> OrderItems { get; set; } = new HashSet<OrderItem>();
        public virtual ICollection<CartItem> CartItems { get; set; } = new HashSet<CartItem>();
    }
}
