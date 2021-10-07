using Entities.Factory;
using Microsoft.EntityFrameworkCore;

namespace Entities
{
    public class ChocolateContext : DbContext
    {
        public ChocolateContext(DbContextOptions<ChocolateContext> contextOptions): base(contextOptions)
        {
            
        }
        public DbSet<Chocolate> Chocolates { get; set; }
        public DbSet<Embalagem> EmbbEmbalagems{ get; set; }
        public DbSet<Produto> Produtos { get; set; }


    }
}