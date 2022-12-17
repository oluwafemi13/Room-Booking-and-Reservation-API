using Hotel_API.Entities;
using Microsoft.EntityFrameworkCore;

namespace Hotel_API.Data
{
    public class DataBaseContext:DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options)
           : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<ContactAddress> Address { get; set; }
        public DbSet<BookingDetail> BookingDetails { get; set; }
        public DbSet<Suite> Suites { get; set; }
    }
}
