using SportsStore.Domain.Entities;
using System.Data.Entity;

namespace SportsStore.Domain.Concrete
{
    //context class

    public class EFDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
