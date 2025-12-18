using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineStore.Data.Models
{
    public class ProductTag
    {
        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; } = null!;

        [ForeignKey(nameof(Tag))]
        public int TagId { get; set; }   
        public virtual Tag Tag { get; set; } = null!;
    }
}
