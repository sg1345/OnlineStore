using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using static OnlineStore.Common.EntityValidation.DigitalDownload;

namespace OnlineStore.Data.Models
{
    public class DigitalDownload
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; } = null!;

        [Required]
        public string FileUrl { get; set; } = null!;

        [Required]
        [MaxLength(DownloadKeyMaxLength)]
        public string DownloadKey { get; set; } = null!;

        public DateTime? AccessExpiry { get; set; }

        [Required]
        public int DownloadLimit { get; set; }

        
    }
}
