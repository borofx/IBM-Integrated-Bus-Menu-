using System;
using System.Collections.Generic;
using IBM___WFA.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace IBM___WFA.Data;

public partial class RazpisanieContext : DbContext
{
    public RazpisanieContext()
    {
    }

    public RazpisanieContext(DbContextOptions<RazpisanieContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Firmi> Firmis { get; set; }

    public virtual DbSet<Razpisaniq> Razpisaniqs { get; set; }

    public virtual DbSet<RazpisaniqFirmi> RazpisaniqFirmis { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-18N09OF\\SQLEXPRESS;Initial Catalog=razpisanie;Integrated Security=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Firmi>(entity =>
        {
            entity.HasKey(e => e.IdFirma).HasName("PK__firmi__4535EF16FD3D48D0");

            entity.ToTable("firmi");

            entity.Property(e => e.IdFirma).HasColumnName("id_firma");
            entity.Property(e => e.Ime)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("ime");
        });

        modelBuilder.Entity<Razpisaniq>(entity =>
        {
            entity.HasKey(e => e.IdMarshrut).HasName("PK__razpisan__E3552D73594A5B0F");

            entity.ToTable("razpisaniq");

            entity.Property(e => e.IdMarshrut).HasColumnName("id_marshrut");
            entity.Property(e => e.ChasPristigane).HasColumnName("chas_pristigane");
            entity.Property(e => e.ChasZaminavane).HasColumnName("chas_zaminavane");
            entity.Property(e => e.PristigaV)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("pristiga_v");
            entity.Property(e => e.ZaminavaOt)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("zaminava_ot");
        });

        modelBuilder.Entity<RazpisaniqFirmi>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("razpisaniq_firmi");

            entity.Property(e => e.IdFirma).HasColumnName("id_firma");
            entity.Property(e => e.IdMarshrut).HasColumnName("id_marshrut");

            entity.HasOne(d => d.IdFirmaNavigation).WithMany()
                .HasForeignKey(d => d.IdFirma)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_firmi");

            entity.HasOne(d => d.IdMarshrutNavigation).WithMany()
                .HasForeignKey(d => d.IdMarshrut)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_razpisaniq");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
