using System;
using System.Collections.Generic;
using CASO3SinScaffolding21100534.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace CASO3SinScaffolding21100534.Data;

public partial class Parcial20240221100534Context : DbContext
{
    public Parcial20240221100534Context()
    {
    }

    public Parcial20240221100534Context(DbContextOptions<Parcial20240221100534Context> options)
        : base(options)
    {
    }

    public virtual DbSet<JobOffer> JobOffer { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=WS2302436;Database=Parcial20240221100534;Integrated Security=true;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<JobOffer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__JobOffer__3214EC071772B9D1");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Location)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
