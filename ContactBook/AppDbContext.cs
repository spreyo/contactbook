using ContactBook.Entities;
using Microsoft.EntityFrameworkCore;

namespace ContactBook
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite($"Data Source=Contact.db");
            }
        }

        public DbSet<Contact> Contacts => Set<Contact>();
        public DbSet<ContactNote> ContactNotes => Set<ContactNote>();
        public DbSet<ContactTag> ContactTags => Set<ContactTag>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>(entity =>
            {
                entity.Property(c => c.FullName)
                .HasMaxLength(120)
                .IsRequired();
                entity.Property(c => c.FirstName)
                .HasMaxLength(60)
                .IsRequired();
                entity.HasIndex(c => c.Email)
                .IsUnique();
            });
        }
    } 
}