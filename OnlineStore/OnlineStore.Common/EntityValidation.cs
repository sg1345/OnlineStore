namespace OnlineStore.Common
{
    public class EntityValidation
    {
        public static class User
        {
            public const int UserNameMaxLength = 50;
            public const int EmailMaxLength = 100;
            public const int FirstNameMaxLength = 50;
            public const int LastNameMaxLength = 50;
        }

        public static class Category
        {
            public const int NameMaxLength = 150;
            public const int SlugMaxLength = 150;
        }

        public static class Product
        {
            public const int NameMaxLength = 200;
            public const int SlugMaxLength = 200;
            public const int SkuMaxLength = 100;

            public const int ShortDescriptionMaxLength = 500;

            public const string PriceColumnType = "decimal(10, 2)";
        }

        public static class ProductVariant
        {
            public const int VariantNameMaxLength = 150;
            public const int SkuMaxLength = 100;

            public const string PriceColumnType = "decimal(10, 2)";
        }

        public static class Inventory
        {
            public const int LocationMaxLength = 100;
        }

        public static class Order
        {
            public const int OrderNumberMaxLength = 50;
            public const int StatusMaxLength = 20;
            public const int CurrencyMaxLength = 10;

            public const string TotalAmountColumnType = "decimal(10, 2)";
        }

        public static class OrderItem
        {
            public const string UnitPriceColumnType = "decimal(10, 2)";
            public const string LineTotalColumnType = "decimal(10, 2)";
        }

        public static class Address
        {
            public const int TypeMaxLength = 20;
            public const int FullNameMaxLength = 150;
            public const int LineOneMaxLength = 200;
            public const int LineTwoMaxLength = 200;
            public const int CityMaxLength = 100;
            public const int PostalCodeMaxLength = 20;
            public const int CountryMaxLength = 100;
            public const int PhoneMaxLength = 50;
        }

        public static class Payment
        {
            public const int PaymentProviderMaxLength = 50;
            public const int ProviderPaymentIdMaxLength = 200;
            public const int CurrencyMaxLength = 10;
            public const int StatusMaxLength = 20;

            public const string AmountColumnType = "decimal(10, 2)";
        }

        public static class Review
        {
            public const int TitleMaxLength = 150;
            public const int RatingMinValue = 1;
            public const int RatingMaxValue = 5;
        }

        public static class ProductImage
        {
            public const int AltTextMaxLength = 200;
        }

        public static class Tag
        {
            public const int NameMaxLength = 100;
            public const int SlugMaxLength = 100;
        }

        public static class DigitalDownload
        {
            public const int DownloadKeyMaxLength = 200;
        }

        public static class AuditLog
        {
            public const int ActionMaxLength = 150;
        }
    }
}
