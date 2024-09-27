namespace TP2console.Models.EntityFramework;

public class FilmPart
{
    public int Idfilm { get; set; }
    public string Nom { get; set; } = null!;
    public string? Description { get; set; }

    public FilmPart(int idfilm, string nom)
    {
        Idfilm = idfilm;
        Nom = nom;
    }

    public override string ToString()
    {
        return Idfilm + " " + Nom; 
    }
}