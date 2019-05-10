using Microsoft.EntityFrameworkCore;
using TPCoinApp.API.Models;

namespace TPCoinApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) {}
        public DbSet<Value> Values { get; set; }
    }
}