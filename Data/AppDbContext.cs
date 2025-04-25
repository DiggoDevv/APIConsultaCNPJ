using APIConsultaCNPJ.Models;
using Microsoft.EntityFrameworkCore;

namespace APIConsultaCNPJ.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<EmpresaModel> Empresas { get; set; }
        public DbSet<UserModel> Users { get; set; } = null!;
    }
}
