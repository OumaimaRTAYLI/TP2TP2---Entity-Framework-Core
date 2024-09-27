namespace TP2console.Models.EntityFramework;

public partial class Avi
{
    public override string ToString()
    {
        return Idfilm + "-" + Idutilisateur;
    }
}