using Microsoft.EntityFrameworkCore;

namespace _1stCodingAssignment.Models
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options)
            : base(options) { }

        public DbSet<Student> Students { get; set; }
    }
}
