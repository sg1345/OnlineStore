using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using OnlineStore.Data.Models.Enum;
using static OnlineStore.Common.EntityValidation.Payment;

namespace OnlineStore.Data.Models
{
    public class Payment
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(Order))]
        public int OrderId { get; set; }
        public virtual Order Order { get; set; } = null!;

        [Required]
        [MaxLength(PaymentProviderMaxLength)]
        public string PaymentProvider { get; set; } = null!;

        [Required]
        [MaxLength(ProviderPaymentIdMaxLength)]
        public string ProviderPaymentId { get; set; } = null!;

        [Required]
        [Column(TypeName = AmountColumnType)]
        public decimal Amount { get; set; }

        [Required]
        [MaxLength(CurrencyMaxLength)]
        public string Currency { get; set; } = null!;

        [Required]
        public PaymentStatus Status { get; set; } 

        [Required]
        public DateTime CreatedAt { get; set; }
    }
}
