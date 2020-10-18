using System;
using Microsoft.EntityFrameworkCore;

namespace TripLog.Models
{
    public class TripContext : DbContext
    {
        public TripContext(DbContextOptions<TripContext> options)
            : base(options)
        { }

        public DbSet<Trip> Trips { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Trip>().HasData(
                new Trip
                {
                    TripID = 1,
                    Destination = "New York City",
                    StartDate = new DateTime(2009, 12, 1),
                    EndDate = new DateTime(2010, 1, 31),
                    AccommodationName = "NY Habitat",
                    AccommodationPhone = "212.255.8018",
                    AccommodationEmail = "info@nyhabitat.com",
                    ThingToDo1 = "Visit Times Square",
                    ThingToDo2 = "See 30 Rockefeller Plaza",
                    ThingToDo3 = "Check out Union Square farmer's market"
                }
            );
        }
    }
}
