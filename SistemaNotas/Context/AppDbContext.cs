using Microsoft.EntityFrameworkCore;
using SistemaNotas.Models;

namespace SistemaNotas.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

        public DbSet<Sefaz> Sefazs { get; set; }

        public DbSet<SistemaNotas.DTOs.SefazDTO> SefazDTO { get; set; }
               
        
    }
}
