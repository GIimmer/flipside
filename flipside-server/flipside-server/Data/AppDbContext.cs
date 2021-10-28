using Flipside_Server.GraphQL;
using Microsoft.EntityFrameworkCore;

namespace Flipside_Server.Data
{
  public class AppDbContext : DbContext
  {
    public AppDbContext(DbContextOptions options): base(options)
    {

    } 

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
    => optionsBuilder
        .UseSnakeCaseNamingConvention();

    public DbSet<Debate> Debates { get; set; }
  }
}