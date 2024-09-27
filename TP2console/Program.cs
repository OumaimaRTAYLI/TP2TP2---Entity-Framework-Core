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
        //Exo2Q3();
        
        //Afficher les noms et id des films de la catégorie « Action »
        //Exo2Q4();
        
        //Afficher le nombre de catégories
        //Exo2Q5();
        
        //Afficher la note la plus basse dans la base
        //Exo2Q6();
        
        //Rechercher tous les films qui commencent par « le »
        //Exo2Q7();
        
        //Afficher la note moyenne du film « Pulp Fiction »
        Exo2Q8();
        
        //Afficher l’utilisateur qui a mis la meilleure note dans la base
        Exo2Q9();

    }

    private static void Exo2Q9()
    {
        var ctx = new FilmsDbContext();

        var maxNote = (from a in ctx.Avis
            join u in ctx.Utilisateurs
                on a.Idutilisateur equals u.Idutilisateur
            select a.Note).Max();
        
        Console.WriteLine(maxNote);
    }

    private static void Exo2Q8()
    {
        var ctx = new FilmsDbContext();

        var avgPulp = ctx.Films.Where(f => f.Nom.ToLower() == "pulp fiction").First()
            .Avis.Average(a => a.Note);

        Console.WriteLine(avgPulp);
    }

    private static void Exo2Q7()
    {
        var ctx = new FilmsDbContext();
        var filmStartLe = ctx.Films.Where(f => f.Nom.StartsWith("Le"));
        Console.WriteLine(filmStartLe.Count());
    }

    private static void Exo2Q6()
    {
        var ctx = new FilmsDbContext();
        var lowestNote = ctx.Avis.OrderBy(a => a.Note).First();
        Console.WriteLine(lowestNote.Note);
    }

    private static void Exo2Q5()
    {
        var ctx = new FilmsDbContext();
        var category = ctx.Categories.Count();
        Console.WriteLine($"Category: {category}");
        
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