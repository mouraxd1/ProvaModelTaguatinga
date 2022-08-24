namespace ProvaModel.Entity;

public class Level
{
    public Level(string? nome)
    {
        Nome = nome;
    }

    public int Id{get; set;}
    public string? Nome{get; set;}
    public ICollection<User> user {get; set;} = null!;
}