using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using static OnlineStore.Common.EntityValidation.Product;

namespace OnlineStore.Data.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(SlugMaxLength)]
        public string Slug { get; set; } = null!;

        [Required]
        [MaxLength(ShortDescriptionMaxLength)]
        public string ShortDescription { get; set; } = null!;

        [Required]
        public string LongDescription { get; set; } = null!;

        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }

        [Required]
        public bool IsDigital { get; set; }

        [Required]
        [Column(TypeName = PriceColumnType)]
        public decimal Price { get; set; }

        [Required]
        [MaxLength(SkuMaxLength)]
        public string Sku { get; set; } = null!;

        public string? MainImageUrl { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public DateTime UpdatedAt { get; set; }

        [Required]
        public bool IsPublished { get; set; }
        [Required]
        public bool StockTracked { get; set; }

        public virtual Category Category { get; set; } = null!;
        public virtual ICollection<ProductVariant> ProductVariants { get; set; } = new HashSet<ProductVariant>();
        public virtual ICollection<ProductImage> ProductImages { get; set; } = new HashSet<ProductImage>();
        public virtual ICollection<Review> Reviews { get; set; } = new HashSet<Review>();
        public virtual ICollection<OrderItem> OrderItems { get; set; } = new HashSet<OrderItem>();
        public virtual DigitalDownload? DigitalDownload { get; set; }
        public virtual ICollection<ProductTag> ProductTags { get; set; } = new HashSet<ProductTag>();
    }
}
