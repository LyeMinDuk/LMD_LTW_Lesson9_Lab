using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BaiTapTuLam02.Models;

public partial class Ltwlesson09Context : DbContext
{
    public Ltwlesson09Context()
    {
    }

    public Ltwlesson09Context(DbContextOptions<Ltwlesson09Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Banner> Banners { get; set; }

    public virtual DbSet<Blog> Blogs { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS; Database=LTWLesson09; MultipleActiveResultSets=True; Integrated Security=True; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Banner>(entity =>
        {
            entity.ToTable("Banner");

            entity.HasIndex(e => e.Name, "UQ_Banner_Name").IsUnique();

            entity.Property(e => e.Description).HasMaxLength(350);
            entity.Property(e => e.Image)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Status).HasDefaultValue((byte)1, "DF_Banner_Status");
        });

        modelBuilder.Entity<Blog>(entity =>
        {
            entity.ToTable("Blog");

            entity.HasIndex(e => e.Name, "UQ_Blog_Name").IsUnique();

            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(CONVERT([date],getdate()))", "DF_Blog_CreatedDate");
            entity.Property(e => e.Description).HasMaxLength(350);
            entity.Property(e => e.Image)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Status).HasDefaultValue((byte)1, "DF_Blog_Status");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.ToTable("Category");

            entity.HasIndex(e => e.Name, "UQ_Category_Name").IsUnique();

            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(CONVERT([date],getdate()))", "DF_Category_CreatedDate");
            entity.Property(e => e.Description).HasMaxLength(350);
            entity.Property(e => e.Image)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Status).HasDefaultValue((byte)1, "DF_Category_Status");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.ToTable("Product");

            entity.HasIndex(e => e.CategoryId, "IX_Product_CategoryId");

            entity.HasIndex(e => e.Name, "UQ_Product_Name").IsUnique();

            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(CONVERT([date],getdate()))", "DF_Product_CreatedDate");
            entity.Property(e => e.Description).HasMaxLength(350);
            entity.Property(e => e.Image)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Status).HasDefaultValue((byte)1, "DF_Product_Status");

            entity.HasOne(d => d.Category).WithMany(p => p.Products)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Product_Category");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
