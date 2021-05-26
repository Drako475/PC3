using Microsoft.EntityFrameworkCore;
using PC3.Models;

namespace PC3.Data
{
    public class ProductoContext : DbContext
    {
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Tecnologia> Tipo { get; set; }

        public ProductoContext(DbContextOptions dco) : base(dco) {

        }
    }
}