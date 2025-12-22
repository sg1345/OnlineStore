using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using OnlineStore.Data.Models.Enum;
using static OnlineStore.Common.EntityValidation.Address;

namespace OnlineStore.Data.Models
{
    public class Address
    {
        public int Id { get; set; }

        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public virtual User User { get; set; } = null!;

        [Required]
        public AddressType Type { get; set; }

        [Required]
        [MaxLength(FullNameMaxLength)]
        public string FullName { get; set; } = null!;

        [Required]
        [MaxLength(LineOneMaxLength)]
        public string Line1 { get; set; } = null!;

        [MaxLength(LineTwoMaxLength)]
        public string? Line2 { get; set; }

        [Required]
        [MaxLength(CityMaxLength)]
        public string City { get; set; } = null!;

        [Required]
        [MaxLength(PostalCodeMaxLength)]
        public string PostalCode { get; set; } = null!;

        [Required]
        [MaxLength(CountryMaxLength)]
        public string Country { get; set; } = null!;

        [Required]
        [MaxLength(PhoneMaxLength)]
        public string Phone { get; set; } = null!;

        [Required]
        public bool IsDefaultShipping { get; set; }

        [Required]
        public bool IsDefaultBilling { get; set; }
    }
}
