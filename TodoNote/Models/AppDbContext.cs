using Microsoft.EntityFrameworkCore;

namespace TodoNote.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Todo> Todos { get; set; }
        public DbSet<Note> Notes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure Todo entity
            modelBuilder.Entity<Todo>()
                .Property(t => t.Title)
                .IsRequired();

            // Configure Note entity
            modelBuilder.Entity<Note>()
                .Property(n => n.Title)
                .IsRequired();

            modelBuilder.Entity<Note>()
                .Property(n => n.Content)
                .IsRequired();
        }
    }
}
