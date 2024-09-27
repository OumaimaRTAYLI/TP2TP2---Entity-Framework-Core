using Microsoft.EntityFrameworkCore;
using TP2console.Models.EntityFramework;

namespace TP2console;

class Program
{
    static void Main(string[] args)
    {
        using (var ctx = new FilmsDbContext())
        {
            
            //Chargement de la catégorie Action
            Categorie categorieAction = ctx.Categories.First(c => c.Nom == "Action");
            Console.WriteLine("Categorie : " + categorieAction.Nom);
            Console.WriteLine("Films : ");
            //Chargement des films de la catégorie Action.
            foreach (var film in categorieAction.Films)
            {
                Console.WriteLine(film.Nom);
            }
        }
    }
}