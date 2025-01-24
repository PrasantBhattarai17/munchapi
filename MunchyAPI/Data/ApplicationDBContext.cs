using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;
using MunchyAPI.Models;

namespace MunchyAPI.Data
{
    public class ApplicationDBContext : DbContext
    {
        //for configuring the entitiyFW core the connection string must be passed into the DbContext so using constructor
        //connsctionstring is passed into the DbContext
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> option) : base(option)
        {


        }
        public DbSet<munch> Munches_API { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<munch>().HasData(
                new munch
                {
                    Id = 1,
                    Name = "Truffle Risotto",
                    Rating = 5,
                    Price = 150,
                    Location = "Downtown",
                    ImgUrl = "https://images.unsplash.com/photo-1612195610857-d20a1a4c38fb",
                    CreatedDate = new DateTime(2025, 1, 24, 12, 0, 0)
                },
                new munch
                {
                    Id = 2,
                    Name = "Lobster Bisque",
                    Rating = 4,
                    Price = 120,
                    Location = "City Center",
                    ImgUrl = "https://images.unsplash.com/photo-1576659000105-f03f4533b30d",
                    CreatedDate = new DateTime(2025, 1, 24, 12, 0, 0)
                },
                new munch
                {
                    Id = 3,
                    Name = "Wagyu Beef Steak",
                    Rating = 5,
                    Price = 200,
                    Location = "Uptown",
                    ImgUrl = "https://images.unsplash.com/photo-1598939359644-c2c6f678ef45",
                    CreatedDate = new DateTime(2025, 1, 24, 12, 0, 0)
                },
                new munch
                {
                    Id = 4,
                    Name = "Duck Confit",
                    Rating = 3,
                    Price = 90,
                    Location = "Suburbs",
                    ImgUrl = "https://images.unsplash.com/photo-1511381242551-df92d18062b0",
                    CreatedDate = new DateTime(2025, 1, 24, 12, 0, 0)
                },
                new munch
                {
                    Id = 5,
                    Name = "Sushi Platter",
                    Rating = 4,
                    Price = 130,
                    Location = "Midtown",
                    ImgUrl = "https://images.unsplash.com/photo-1565104283-5d78c063ac8a",
                    CreatedDate = new DateTime(2025, 1, 24, 12, 0, 0)
                }
            );
        }

    }
}
