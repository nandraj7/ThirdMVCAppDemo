using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ThirdMVCAppDemo.Models;

public partial class SecondMvcappDemoContext : DbContext
{
    public SecondMvcappDemoContext()
    {
    }

    public SecondMvcappDemoContext(DbContextOptions<SecondMvcappDemoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("server=localhost\\SQLEXPRESS; database=SecondMVCAppDemo; trusted_connection=true; trustservercertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Users__3214EC070F01C3E9");

            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
