using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using static OnlineStore.Common.EntityValidation.ProductImage;

namespace OnlineStore.Data.Models
{
    public class ProductImage
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; } = null!;

        [Required]
        public string ImageUrl { get; set; } = null!;

        [Required]
        public int SortOrder { get; set; }

        [Required]
        [MaxLength(AltTextMaxLength)]
        public string AltText { get; set; } = null!;


    }
}
