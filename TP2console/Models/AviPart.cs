namespace TP2console.Models.EntityFramework;

public partial class AviPart
{
    public int Idfilm { get; set; }
    public int Idutilisateur { get; set; }
    public string? Commentaire { get; set; }
    public decimal Note { get; set; }

    public AviPart(int idfilm, int idutilisateur)
    {
        Idfilm = idfilm;
        Idutilisateur = idutilisateur;
    }

    public override string ToString()
    {
        return Idfilm + "-" + Idutilisateur;
    }
}