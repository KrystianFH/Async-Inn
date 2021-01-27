using AsyncInn.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Data
{
    public class AsyncInnDbContext : DbContext
    { 
        public AsyncInnDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Amenity>().HasData(
               new Amenity { ID = 1, Name = "Mini Fridge" },
               new Amenity { ID = 2, Name = "Whirlpool Tub" }
               );

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    ID = 1,
                    Name = "First Hotel",
                    City = "New Orleans",
                    Country = "USA",
                    Phone = "5551234567",
                    State = "Louisiana",
                    StreetAddress = "01 Hotel Street"
                },
                new Hotel {
                    ID = 2,
                    Name = "Second Hotel",
                    City = "San Antonio",
                    Country = "USA",
                    Phone = "5552345678",
                    State = "Texas",
                    StreetAddress = "02 Motel Row"
                });

            modelBuilder.Entity<Room>().HasData(
                new Room { ID = 1, Layout = 1, Name = "Single Bed" },
                new Room { ID = 2, Layout = 2, Name = "Double Bed" },
                new Room { ID = 3, Layout = 3, Name = "Queen Suite" },
                new Room { ID = 4, Layout = 4, Name = "King Suite" });
        }

       
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Amenity> Amenities { get; set; }

        

    }
}
