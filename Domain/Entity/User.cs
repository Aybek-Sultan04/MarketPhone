namespace Domain.Entity;

public class User
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Telegram_username { get; set; }
    public string? Password { get; set; }
    public IEnumerable<Post>? Posts { get; set; }

    public IEnumerable<Favourite>? Favourites { get; set; }
}
