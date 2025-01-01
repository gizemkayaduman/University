using Microsoft.EntityFrameworkCore;
using University.Models.Entities; // Modellerin bulunduğu namespace

namespace UniversityDb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Grades> Grades { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Course>()
                .HasKey(c => c.CNUM); // CNUM'u birincil anahtar olarak tanımla

            modelBuilder.Entity<Section>()
                .HasKey(s => new { s.SECCOURSE, s.SECNUM }); // Birleşik birincil anahtar

            modelBuilder.Entity<Grades>()
                .HasKey(g => new { g.SECCOURSE, g.SECNUM, g.SEMESTER, g.YEAR, g.SNUM }); // Birleşik birincil anahtar

            modelBuilder.Entity<Department>()
                .HasKey(d => d.DEPTCODE); // DEPTCODE birincil anahtar olarak tanımlandı

            modelBuilder.Entity<Student>()
                .HasKey(s => s.SNUM); // SNUM birincil anahtar olarak tanımlandı

        }
    }
}
