using Flipside_Server.GraphQL;
using Microsoft.EntityFrameworkCore;

namespace Flipside_Server.Data
{
  public class AppDbContext : DbContext
  {
    public AppDbContext(DbContextOptions options): base(options) {} 

    public DbSet<Debate> Debates { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Argument> Arguments { get; set; }
    public DbSet<Comment> Comments { get; set; }
  }
}