using Microsoft.EntityFrameworkCore;
using static OnlineStore.Common.ApplicationConstants;
using OnlineStore.Data.Models;

namespace OnlineStore.Data
{
    public class OnlineStoreContext : DbContext
    {
        public OnlineStoreContext()
        {
        }
        public OnlineStoreContext(DbContextOptions<OnlineStoreContext> options)
            : base(options)
        {
        }
        
        public DbSet<Address> Addresses { get; set; } = null!;
        public DbSet<AuditLog> AuditLogs { get; set; } = null!;
        public DbSet<CartItem> CartItems { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<DigitalDownload> DigitalDownloads { get; set; } = null!;
        public DbSet<Inventory> Inventories { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<OrderItem> OrdersItems { get; set; } = null!;
        public DbSet<Payment> Payments { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<ProductImage> ProductImages { get; set; } = null!;
        public DbSet<ProductTag> ProductTags { get; set; } = null!;
        public DbSet<ProductVariant> ProductVariants { get; set; } = null!;
        public DbSet<Review> Reviews { get; set; } = null!;
        public DbSet<ShoppingCart> ShoppingCarts { get; set; } = null!;
        public DbSet<Tag> Tags { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlServer(ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //Address
            builder.Entity<Address>()
                .HasIndex(a => new { a.UserId, a.Type });

            //AuditLog
            builder.Entity<AuditLog>()
                .HasIndex(a => new { a.UserId, a.CreatedAt });

            //CartItem
            builder.Entity<CartItem>()
                .HasIndex(ci => new { ci.CartId, ci.ProductId, ci.ProductVariantId })
                .IsUnique();

            //Category
            builder
                .Entity<Category>()
                .HasIndex(c => c.Slug)
                .IsUnique();

            //DigitalDownload
            builder.Entity<DigitalDownload>()
                .HasOne(dd => dd.Product)
                .WithOne(p => p.DigitalDownload)
                .HasForeignKey<DigitalDownload>(dd => dd.ProductId);

            builder.Entity<DigitalDownload>()
                .HasIndex(dd => dd.DownloadKey)
                .IsUnique();

            //Inventory
            builder.Entity<Inventory>()
                .HasOne(i => i.ProductVariant)
                .WithOne(pv => pv.Inventory)
                .HasForeignKey<Inventory>(i => i.ProductVariantId);

            //OrderItem
            builder.Entity<OrderItem>()
                .HasKey(oi => new { oi.OrderId, oi.ProductId, oi.ProductVariantId });

            //Payment
            builder.Entity<Payment>()
                .HasOne(p => p.Order)
                .WithOne(o => o.Payment)
                .HasForeignKey<Payment>(p => p.OrderId);

            builder.Entity<Payment>()
                .HasIndex(p => p.ProviderPaymentId)
                .IsUnique();

            //Product
            builder
                .Entity<Product>()
                .HasIndex(p => p.Slug)
                .IsUnique();

            builder
                .Entity<Product>()
                .HasIndex(p => p.Sku)
                .IsUnique();

            //ProductTag
            builder.Entity<ProductTag>()
                .HasKey(pt => new { pt.ProductId, pt.TagId });

            //ProductVariant
            builder
                .Entity<ProductVariant>()
                .HasIndex(v => v.Sku)
                .IsUnique();

            //Review
            builder.Entity<Review>()
                .HasIndex(r => new { r.ProductId, r.UserId })
                .IsUnique();

            builder.Entity<Review>()
                .HasIndex(r => r.IsApproved);

            //Tag
            builder.Entity<Tag>()
                .HasIndex(t => t.Slug)
                .IsUnique();
        }
    }
}
