using Microsoft.EntityFrameworkCore;

namespace EfCorePractice.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppContext> options) : base(options)
        {

        }
    }
}
