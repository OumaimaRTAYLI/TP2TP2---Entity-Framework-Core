namespace TP2console.Models.EntityFramework;

public class CategoriePart
{
    public int Idcategorie { get; set; }
    public string Nom { get; set; } = null!;
    public string? Description { get; set; }

    public CategoriePart(int idcategorie, string nom)
    {
        Idcategorie = idcategorie;
        Nom = nom;
    }

    public override string ToString()
    {
        return Idcategorie + " - " + Nom;
    }
}