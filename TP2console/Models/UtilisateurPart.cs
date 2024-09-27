namespace TP2console.Models.EntityFramework;

public partial class Utilisateur
{
    public override string ToString()
    {
        return Idutilisateur + " " + Login;
    }
}