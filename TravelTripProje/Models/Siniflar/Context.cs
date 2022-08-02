using System.Data.Entity;

namespace TravelTripProje.Models.Siniflar
{
    public class Context : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<AddressBlog> AddressBlogs { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Abouts> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}