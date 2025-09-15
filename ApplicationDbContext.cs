using Microsoft.EntityFrameworkCore;
using WebAPI_2.Entities;

namespace WebAPI_2;
public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<User> Users { get; set; }
    public DbSet<Post> Posts { get; set; }
}    
