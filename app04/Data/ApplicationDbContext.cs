using Microsoft.EntityFrameworkCore;

namespace app04.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) {
        }
    }
}
