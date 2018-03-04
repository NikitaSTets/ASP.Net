namespace DepartmentStore
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Shop : DbContext
    {
        public Shop()
            : base("name=Shop")
        {
        }

        public virtual DbSet<ShopInfo> ShopInfoes { get; set; }
        public virtual DbSet<ProductInfo> ProductInfoes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ShopInfo>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<ShopInfo>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<ShopInfo>()
                .Property(e => e.mode)
                .IsUnicode(false);

            modelBuilder.Entity<ShopInfo>()
                .HasMany(e => e.ProductInfoes)
                .WithRequired(e => e.ShopInfo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProductInfo>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<ProductInfo>()
                .Property(e => e.description)
                .IsUnicode(false);
        }
    }
}
