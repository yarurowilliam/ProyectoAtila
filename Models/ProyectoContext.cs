using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AtilaV1.Models
{
    public partial class ProyectoContext : DbContext
    {
        public ProyectoContext()
        {
        }

        public ProyectoContext(DbContextOptions<ProyectoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Asignaturas> Asignaturas { get; set; }
        public virtual DbSet<Convocatoria> Convocatoria { get; set; }
        public virtual DbSet<Docentes> Docentes { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-3K3G9M7\\SQLEXPRESS;Initial Catalog=Proyecto;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Asignaturas>(entity =>
            {
                entity.HasKey(e => e.IdAsignatura)
                    .HasName("PK__ASIGNATU__0E69A2E93CAA6CC5");

                entity.ToTable("ASIGNATURAS");

                entity.Property(e => e.IdAsignatura)
                    .HasColumnName("ID_ASIGNATURA")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NombreAsignatura)
                    .HasColumnName("NOMBRE_ASIGNATURA")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Convocatoria>(entity =>
            {
                entity.HasKey(e => e.IdConvocatoria)
                    .HasName("PK__CONVOCAT__70981A0644E7064F");

                entity.ToTable("CONVOCATORIA");

                entity.Property(e => e.IdConvocatoria)
                    .HasColumnName("ID_CONVOCATORIA")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaFinal)
                    .HasColumnName("FECHA_FINAL")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaInicial)
                    .HasColumnName("FECHA_INICIAL")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Docentes>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DOCENTES");

                entity.Property(e => e.Contraseña)
                    .HasColumnName("CONTRASEÑA")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Correo)
                    .HasColumnName("CORREO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnName("FECHA_NACIMIENTO")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdDocente)
                    .IsRequired()
                    .HasColumnName("ID_DOCENTE")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IdRol)
                    .HasColumnName("ID_ROL")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PrimerApellido)
                    .IsRequired()
                    .HasColumnName("PRIMER_APELLIDO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PrimerNombre)
                    .IsRequired()
                    .HasColumnName("PRIMER_NOMBRE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SegundoApellido)
                    .HasColumnName("SEGUNDO_APELLIDO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SegundoNombre)
                    .HasColumnName("SEGUNDO_NOMBRE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasColumnName("TELEFONO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdRolNavigation)
                    .WithMany(p => p.Docentes)
                    .HasForeignKey(d => d.IdRol)
                    .HasConstraintName("fk_ID_ROL");
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.HasKey(e => e.IdRol)
                    .HasName("PK__ROLES__203B0F6892EC3999");

                entity.ToTable("ROLES");

                entity.Property(e => e.IdRol)
                    .HasColumnName("ID_ROL")
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NombreRol)
                    .HasColumnName("NOMBRE_ROL")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
