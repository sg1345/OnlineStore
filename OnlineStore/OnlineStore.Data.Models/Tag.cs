using System.ComponentModel.DataAnnotations;
using static OnlineStore.Common.EntityValidation.Tag;

namespace OnlineStore.Data.Models
{
    public class Tag
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(SlugMaxLength)]
        public string Slug { get; set; } = null!;

        public virtual ICollection<ProductTag> ProductTags { get; set; } = new HashSet<ProductTag>();
    }
}
