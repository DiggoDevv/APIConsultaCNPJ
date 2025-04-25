using Microsoft.EntityFrameworkCore;

namespace APIConsultaCNPJ.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Models.UserModel> Users { get; set; } = null!;
    }
}
