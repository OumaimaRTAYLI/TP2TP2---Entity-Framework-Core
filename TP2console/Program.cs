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
        Exo2Q2();
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