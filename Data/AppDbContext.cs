using Microsoft.EntityFrameworkCore;

namespace EfCorePractice.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        DbSet<Student> Students { get; set; }
    }
}
