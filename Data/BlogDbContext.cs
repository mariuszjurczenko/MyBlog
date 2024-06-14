using MyBlog.Models;
using Microsoft.EntityFrameworkCore;

namespace MyBlog.Data;

public class BlogDbContext : DbContext
{
    public DbSet<Post> Posts { get; set; }
    public DbSet<Comment> Comments { get; set; }

    public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options)
    {
    }
}