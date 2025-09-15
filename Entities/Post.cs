namespace WebAPI_2.Entities;

public class Post
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime Created { get; set;  }
    public DateTime Updated { get; set; }
}
