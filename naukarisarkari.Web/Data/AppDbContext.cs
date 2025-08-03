using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<JobPost> JobPosts { get; set; }
    public DbSet<AdminUser> AdminUsers { get; set; }
}
