using MagicVilla_VillaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VillaAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                    new Villa {
                        Id = 1,
                        Name =     "Royal villa",
                        Details =  "\r\nA royal villa, often characterized by opulence and grandeur," +
                                   "stands as an epitome of regal luxury and architectural magnificence. " +
                                   "Situated amidst lush landscapes, " +
                                   "these stately residences serve as a testament to the historical significance and refined taste of royalty. " +
                                   "Here, I'll provide an English description of a royal villa, capturing its essence in approximately 100 words.",
                        ImageUrl = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fmcmtenerife.com%2Fkakie-sushhestvuyut-razlichiya-mezhdu-villoj-i-osobnyakom%2F&psig=AOvVaw2AaMNX-GZ4-4Rpipf5Q8iQ&ust=1705954550626000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCOjkwvWl74MDFQAAAAAdAAAAABAD",
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
