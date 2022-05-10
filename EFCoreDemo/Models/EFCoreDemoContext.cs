using Microsoft.EntityFrameworkCore;

namespace EFCoreDemo.Models
{
    public class EFCoreDemoContext:DbContext
    {
        public EFCoreDemoContext(DbContextOptions<EFCoreDemoContext> options)
           :base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

    }
}
