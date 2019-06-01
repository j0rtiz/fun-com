using Microsoft.EntityFrameworkCore;

namespace fun_com.Models
{
  public class Context : DbContext
  {
    public Context(DbContextOptions<Context> options) : base(options) { }
    public DbSet<Produto> Produtos { get; set; }
  }
}
