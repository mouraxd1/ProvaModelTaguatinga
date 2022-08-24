namespace ProvaModel.Entity;

public class User 
{
    public User(string? nome, string? sobrenome, string? login, string? password)
    {
        Nome = nome;
        Sobrenome = sobrenome;
        Login = login;
        Password = password;
    }

    public int iD{get; set;}
    public string? Nome{get; set;}
    public string? Sobrenome{get; set;}
    public string? Login{get; set;}
    public string? Password{get; set;}
    public int LeveliD{get; set;}
    public Level level{get; set;} = null!;
}