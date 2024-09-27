using Microsoft.EntityFrameworkCore;
using TP2console.Models.EntityFramework;

namespace TP2console;

class Program
{
    static void Main(string[] args)
    {
        //Afficher tous les films
        //Exo2Q1();
        
        //Afficher les emails de tous les utilisateurs
        //Exo2Q2();
        
        //Afficher les utlisateurs triés par login croissant 
        Exo2Q3();
        
        //Afficher les noms et id des films de la catégorie « Action »
        Exo2Q4();
    }

    private static void Exo2Q4()
    {
        var ctx = new FilmsDbContext();
        var category = ctx.Categories.First(c => c.Nom == "Action");
        var films = ctx.Films.Where(o => o.Idcategorie == category.Idcategorie);
        foreach (var film in films)
        {
            Console.WriteLine(film.Idfilm + ":" + film.Nom);            
        }
    }

    private static void Exo2Q3()
    {
        var ctx = new FilmsDbContext();
        var sortedUsers = ctx.Utilisateurs.OrderBy(o => o.Login);
        foreach (var user in sortedUsers)
        {
            Console.WriteLine(user.Login);
        }

    }

    private static void Exo2Q2()
    {
        var ctx = new FilmsDbContext();
        Console.WriteLine("Les emails des utilisateurs : ");
        foreach (var utilisateur in ctx.Utilisateurs )
        {
            Console.WriteLine(utilisateur.Email);
        }
    }

    private static void Exo2Q1()
    {
        var ctx = new FilmsDbContext();
        foreach (var film in ctx.Films)
        {
            Console.WriteLine(film.ToString());
        }
    }
    
    
}