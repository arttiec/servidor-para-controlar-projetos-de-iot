using Microsoft.EntityFrameworkCore;
using PrototypeControlStem.Models;

namespace PrototypeControlStem.Data;

public partial class DbStemContext : DbContext
{
    public DbStemContext()
    {
    }

    public DbStemContext(DbContextOptions<DbStemContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Prototype> Prototypes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("Host=localhost;Database=db_stem;Username=postgres;Password=Ghr432311&");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Prototype>(entity =>
        {
            entity.HasKey(e => e.CodPrototype).HasName("prototypes_pkey");

            entity.ToTable("prototypes");

            entity.Property(e => e.CodPrototype)
                .HasMaxLength(5)
                .HasColumnName("cod_prototype");
            entity.Property(e => e.LastConnectionPrototype)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("last_connection_prototype");
            entity.Property(e => e.LocalPrototype)
                .HasMaxLength(40)
                .HasColumnName("local_prototype");
            entity.Property(e => e.NamePrototype)
                .HasMaxLength(20)
                .HasColumnName("name_prototype");
            entity.Property(e => e.StatusPrototype).HasColumnName("status_prototype");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
