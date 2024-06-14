using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyBlog.Models;

public class Comment
{
    [Key]
    public Guid Id { get; set; }
    public string Content { get; set; }
    public string Author { get; set; }
    public DateTime CreatedAt { get; set; }
    
    [ForeignKey("PostId")]
    public Guid PostId { get; set; }
    public Post Post { get; set; }

    public Comment()
    {
        Id = Guid.NewGuid();
        CreatedAt = DateTime.UtcNow;
    }
}