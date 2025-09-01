using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;  // appsettings.json okumak için
using Microsoft.Extensions.DependencyInjection; // AddDbContext için


namespace travelproject.Models.Classes
{
  public class Context : DbContext

  {

    public Context(DbContextOptions<Context> options) : base(options)
    {
    }
    public DbSet<Admin> Admins { get; set; }
    public DbSet<AdressBlog> AdressBlogs { get; set; }
    public DbSet<Comments> Comments { get; set; }
    public DbSet<About> Abouts { get; set; }
    public DbSet<Contact> Contacts { get; set; }

    public DbSet<MyBlog> MyBlog { get; set; }
         
       }
    
}
