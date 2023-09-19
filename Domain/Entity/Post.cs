namespace Domain.Entity;

public class Post
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Text { get; set; }
    public DateTime? WritedDate { get; set; }
    public bool IsActive { get; set; }

    public int UserId { get; set; }
    public User? User { get; set; }

    public int PhoneId { get; set; }
    public Phone? Phone { get; set; }
}
