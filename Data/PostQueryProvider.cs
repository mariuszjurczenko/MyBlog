using MyBlog.Models;

namespace MyBlog.Data;

public class PostQueryProvider
{
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<Post> GetPosts([Service] BlogDbContext context) => context.Posts;

    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<Comment> GetComments([Service] BlogDbContext context) => context.Comments;
}