using Microsoft.EntityFrameworkCore;

namespace BaiTapTuLam02.Models;

public partial class Ltwlesson09Context
{
    // Cột Status có DEFAULT 1 nên EF sẽ bỏ qua giá trị 0 (Ẩn) khi INSERT.
    // ValueGeneratedNever buộc EF luôn gửi giá trị người dùng chọn.
    partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Banner>().Property(e => e.Status).ValueGeneratedNever();
        modelBuilder.Entity<Blog>().Property(e => e.Status).ValueGeneratedNever();
        modelBuilder.Entity<Category>().Property(e => e.Status).ValueGeneratedNever();
        modelBuilder.Entity<Product>().Property(e => e.Status).ValueGeneratedNever();
    }
}
