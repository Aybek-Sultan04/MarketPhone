namespace Domain.Entity;

public class Favourite
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public User? User { get; set; }

    public int PhoneId { get; set; }
    public Phone? Phone { get; set; }
}
