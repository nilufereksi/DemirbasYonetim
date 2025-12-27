using Microsoft.EntityFrameworkCore;
using DemirbasYonetim.Models; 

namespace DemirbasYonetim.Data
{
    // DbContext'ten miras alarak EF Core yeteneklerini kazandırdım
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

   // Veritabanında oluşacak tabloları burada tanımladım burdda
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Location> Locations { get; set; }
    }
}