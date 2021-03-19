using Microsoft.EntityFrameworkCore;

namespace Factory.Models
{
  public class FactoryContext : DbContext
  {
    //each DbSet will become a table in database
    public virtual DbSet<Machine> Machines { get; set; }
    public DbSet<Engineer> Engineers { get; set; }
    public DbSet<MachineEngineer> MachineEngineer { get; set; }

    public FactoryContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguration(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}