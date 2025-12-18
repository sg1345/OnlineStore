using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using static OnlineStore.Common.EntityValidation.Inventory;

namespace OnlineStore.Data.Models
{
    public class Inventory
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(ProductVariant))]
        public int ProductVariantId { get; set; }
        public virtual ProductVariant ProductVariant { get; set; } = null!;

        [Required]
        public int Quantity { get; set; }

        [MaxLength(LocationMaxLength)]
        public string? Location { get; set; }

    }
}
