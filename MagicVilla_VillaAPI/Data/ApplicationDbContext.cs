using MagicVilla_VillaAPI.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VillaAPI.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<ApplicationUser> ApplicationUserUsers { get; set; }
        public DbSet<LocalUser> Users { get; set; }
        public DbSet<Villa> Villas { get; set; }
        public DbSet<VillaNumber> VillaNumbers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Villa>().HasData(
                    new Villa {
                        Id = 1,
                        Name =     "Royal villa",
                        Details =  "\r\nA royal villa, often characterized by opulence and grandeur," +
                                   "stands as an epitome of regal luxury and architectural magnificence. " +
                                   "Situated amidst lush landscapes, " +
                                   "these stately residences serve as a testament to the historical significance and refined taste of royalty. " +
                                   "Here, I'll provide an English description of a royal villa, capturing its essence in approximately 100 words.",
                        ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa1.jpg",
                        Occupancy = 5,
                        Rate = 200,
                        Sqft = 500,
                        Amenity = "",
                        CreatedDate = DateTime.Now,
                    }
                );
        }
    }
}
