using Microsoft.EntityFrameworkCore;
using Tap.School.Api.Entities;

namespace Tap.School.Api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated(); 
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .Property(s => s.LastName)
                .IsRequired();

            modelBuilder.Entity<Student>()
                .Property(s => s.FirstName)
                .HasMaxLength(150);

            base.OnModelCreating(modelBuilder);
        }
    }
}
