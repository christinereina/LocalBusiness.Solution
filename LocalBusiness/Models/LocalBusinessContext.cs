using Microsoft.EntityFrameworkCore;

namespace LocalBusiness.Models
{
    public class LocalBusinessContext : DbContext
    {
        public LocalBusinessContext(DbContextOptions<LocalBusinessContext> options)
            : base(options)
        {
        }

        public DbSet<Business> Businesses { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
         builder.Entity<Business>()
            .HasData(
          new Business { BusinessId = 1, Name = "Totoro's Seeds & Trees", Rating = "5", Type = "Nursery", Address = "1234 Camphor St.", Hours = "10 AM - 5 PM", ServicesOffered = "Planting Services" },
          new Business { BusinessId = 2, Name = "Kiki's Delivery Service", Rating = "5", Type = "Delivery", Address = "44 Jiji Rd", Hours = "7 AM - 12 PM", ServicesOffered = "Broomstick Delivery, Cleaning Service" },
          new Business { BusinessId = 3, Name = "Yubaba's BathHouse", Rating = "2", Type = "Bathhouse", Address = "7853 Sen Lane", Hours = "24/7", ServicesOffered = "Spirit Relaxation, Cleaning and Luxury Pampering" },
          new Business { BusinessId = 4, Name = "Ponyo & Sōsuke Boat Rental", Rating = "5", Type = "Boating", Address = "Seaside Cliff", Hours = "6 AM - 10 PM", ServicesOffered = "Boat Rental, Boat Repair" },
          new Business { BusinessId = 5, Name = "Hotel Adriano", Rating = "4", Type = "Hotel", Address = "6757 Gina Lane", Hours = "Reception Hours: 5 AM - 12 PM", ServicesOffered = "Nightly Accommodations" }

      );
}
    }
}