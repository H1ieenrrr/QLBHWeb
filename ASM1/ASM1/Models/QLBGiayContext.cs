using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ASM1.Models
{
    public partial class QLBGiayContext : DbContext
    {
        public QLBGiayContext()
        {
        }

        public QLBGiayContext(DbContextOptions<QLBGiayContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cart> Cart { get; set; }
        public virtual DbSet<CartDetail> CartDetail { get; set; }
        public virtual DbSet<Catgorys> Catgorys { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //            if (!optionsBuilder.IsConfigured)
            //            {
            //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            //                optionsBuilder.UseSqlServer("Server=LAPTOP-BGDCBQC8\\TANHIEN; Initial Catalog=QLBGiay;Integrated Security=True");
            //            }
            var builder = new ConfigurationBuilder()
                                 .SetBasePath(Directory.GetCurrentDirectory())
                                 .AddJsonFile("appsettings.json");
            var configuration = builder.Build();
            optionsBuilder.UseSqlServer(configuration["ConnectionStrings:QLBGiayDatabase"]);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cart>(entity =>
            {
                entity.Property(e => e.CartId).HasColumnName("Cart_Id");

                entity.Property(e => e.CustomerId).HasColumnName("Customer_Id");

                entity.Property(e => e.UsersId).HasColumnName("Users_Id");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Cart)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK__Cart__Customer_I__1A14E395");

                entity.HasOne(d => d.Users)
                    .WithMany(p => p.Cart)
                    .HasForeignKey(d => d.UsersId)
                    .HasConstraintName("FK__Cart__Users_Id__1920BF5C");
            });

            modelBuilder.Entity<CartDetail>(entity =>
            {
                entity.ToTable("Cart_Detail");

                entity.Property(e => e.CartDetailId).HasColumnName("CartDetail_Id");

                entity.Property(e => e.CartId).HasColumnName("Cart_Id");

                entity.Property(e => e.CustomerId).HasColumnName("Customer_Id");

                entity.Property(e => e.ProductAmount).HasColumnName("Product_Amount");

                entity.Property(e => e.ProductId).HasColumnName("Product_Id");

                entity.Property(e => e.ProductName)
                    .HasColumnName("Product_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.ProductPrice).HasColumnName("Product_Price");

                entity.Property(e => e.TotalPrice).HasColumnName("Total_Price");

                entity.HasOne(d => d.Cart)
                    .WithMany(p => p.CartDetail)
                    .HasForeignKey(d => d.CartId)
                    .HasConstraintName("FK__Cart_Deta__Total__1CF15040");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.CartDetail)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__Cart_Deta__Produ__1DE57479");
            });

            modelBuilder.Entity<Catgorys>(entity =>
            {
                entity.HasKey(e => e.CatgoryId)
                    .HasName("PK__Catgorys__D7E6748C07A217B7");

                entity.Property(e => e.CatgoryId).HasColumnName("Catgory_Id");

                entity.Property(e => e.ProductId).HasColumnName("Product_Id");

                entity.Property(e => e.ProductName)
                    .HasColumnName("Product_Name")
                    .HasMaxLength(200);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Catgorys)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK__Catgorys__Produc__1273C1CD");
            });

            modelBuilder.Entity<Customers>(entity =>
            {
                entity.HasKey(e => e.CustomerId)
                    .HasName("PK__Customer__8CB28699E75B8F11");

                entity.Property(e => e.CustomerId).HasColumnName("Customer_Id");

                entity.Property(e => e.CustomerAddress)
                    .HasColumnName("Customer_Address")
                    .HasMaxLength(200);

                entity.Property(e => e.CustomerEmail)
                    .HasColumnName("Customer_Email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .HasColumnName("Customer_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.CustomerPhone)
                    .HasColumnName("Customer_Phone")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Products>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("PK__Products__9834FBBA2AB7A50C");

                entity.Property(e => e.ProductId).HasColumnName("Product_Id");

                entity.Property(e => e.CatgoryId).HasColumnName("Catgory_Id");

                entity.Property(e => e.ProductAmount).HasColumnName("Product_Amount");

                entity.Property(e => e.ProductDate)
                    .HasColumnName("Product_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProductImage)
                    .HasColumnName("Product_Image")
                    .HasMaxLength(200);

                entity.Property(e => e.ProductName)
                    .HasColumnName("Product_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.ProductPrice)
                    .HasColumnName("Product_Price")
                    .HasColumnType("money");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.Property(e => e.UsersId).HasColumnName("Users_Id");

                entity.Property(e => e.UsersEmail)
                    .HasColumnName("Users_Email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsersName)
                    .HasColumnName("Users_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.UsersPassword)
                    .HasColumnName("Users_Password")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsersPhone)
                    .HasColumnName("Users_Phone")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
