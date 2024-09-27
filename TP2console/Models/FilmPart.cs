namespace TP2console.Models.EntityFramework;

public partial class Film
{
    public override string ToString()
    {
        return Idfilm + " " + Nom; 
    }
}