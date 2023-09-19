using Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.DB;

public class MarketPhoneDBContext:DbContext
{
    public MarketPhoneDBContext()
    {
    }

    public MarketPhoneDBContext(DbContextOptions options):base(options) 
    {
        
    }
    public DbSet<User> Users { get; set; }
    public DbSet<Phone> Phones { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<Favourite> Favorites { get; set; }

    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string config = File.ReadAllText(@"../Infrastructure/DB/ConfigForDb.txt");
        optionsBuilder.UseNpgsql(config);
    }
}
