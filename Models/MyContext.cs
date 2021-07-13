using Microsoft.EntityFrameworkCore;
namespace Project.Models
{
    // the MyContext class representing a session with our MySQL
    // database allowing us to query for or save data
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) { }
        // the "FavoriteMoviess" table name will come from the DbSet variable name
        public DbSet<User> Users { get; set; }
        public DbSet<Resort> Resorts { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Favorite> Favorites { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Review> Reviews { get; set; }




  
    }
}