using Microsoft.EntityFrameworkCore;

namespace fun_com.Models
{
  public class dbContext : DbContext
  {
    public dbContext(DbContextOptions<dbContext> options) : base(options) { }
    public DbSet<Produto> Produtos { get; set; }
  }
}
