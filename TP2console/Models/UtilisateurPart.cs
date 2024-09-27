namespace TP2console.Models.EntityFramework;

public class UtilisateurPart
{
    public int Idutilisateur { get; set; }
    public string Login { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Pwd { get; set; } = null!;

    public UtilisateurPart(int idutilisateur, string login)
    {
        Idutilisateur = idutilisateur;
        Login = login;
    }

    public override string ToString()
    {
        return Idutilisateur + " " + Login;
    }
}