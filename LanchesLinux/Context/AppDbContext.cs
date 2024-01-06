using LanchesLinux.Models;
using Microsoft.EntityFrameworkCore;

namespace LanchesLinux.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
        }

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Lanche> Lanches { get; set; }
    }
}
