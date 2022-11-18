using Vehiculos20200852.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Vehiculos20200852.Data.Context;

public class MyDbContext:DbContext

{
    public MyDbContext(DbContextOptions options):base(options)
    {
        
    }
    public virtual DbSet<Vehiculo> Vehiculos {get; set;} = null!;
    public override int SaveChanges()
    {
        return base.SaveChanges();
    }
    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return base.SaveChangesAsync(cancellationToken);
    }
}

public interface IMyDbContext
{
    public DbSet<Vehiculo> Vehiculos {get; set;}
    public int SaveChanges();
    public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}


