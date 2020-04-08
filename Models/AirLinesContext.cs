using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AirLine.Models
{
    public partial class AirLinesContext : DbContext
    {
        public AirLinesContext()
        {
        }

        public AirLinesContext(DbContextOptions<AirLinesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Passeggero> Passeggero { get; set; }
        public virtual DbSet<Persona> Persona { get; set; }
        public virtual DbSet<Volo> Volo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
//             if (!optionsBuilder.IsConfigured)
//             {
// #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                 optionsBuilder.UseSqlServer("Server=DN-NB0282;Database=AirLines;Trusted_Connection=True;");
//             }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Passeggero>(entity =>
            {
                entity.HasOne(d => d.IdPersonaNavigation)
                    .WithMany(p => p.Passeggero)
                    .HasForeignKey(d => d.IdPersona)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Passeggero_Persona");

                entity.HasOne(d => d.IdVoloNavigation)
                    .WithMany(p => p.Passeggero)
                    .HasForeignKey(d => d.IdVolo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Passeggero_Volo");
            });

            modelBuilder.Entity<Persona>(entity =>
            {
                entity.Property(e => e.Cognome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nascita).HasColumnType("datetime");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Volo>(entity =>
            {
                entity.Property(e => e.DataArrivo).HasColumnType("datetime");

                entity.Property(e => e.DataPartenza).HasColumnType("datetime");

                entity.Property(e => e.LuogoArrivo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LuogoPartenza)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}