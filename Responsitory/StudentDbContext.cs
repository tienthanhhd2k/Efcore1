using Microsoft.EntityFrameworkCore;

namespace efcore1.Models {
    public class StudentDbContext : DbContext {
        public StudentDbContext() { }
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base (options) { }

        // // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     optionsBuilder.UseSqlServer("Server=TIXNTHXNH;Initial Catalog=DBName;Integrated Security=True");
        // }

        public DbSet<Student> Student { get; set; } 
    }
}