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
            Categorie categorieAction = ctx.Categories
                .Include(c => c.Films)
                .ThenInclude(f => f.Avis)
                .First(c => c.Nom == "Action");
            Console.WriteLine("Categorie : " + categorieAction.Nom);
            Console.WriteLine("Films : ");
            //Chargement des films de la catégorie Action.
            foreach (var film in categorieAction.Films)
            {
                Console.WriteLine(film.Nom);
                //Console.WriteLine(film.Avis.GetEnumerator
                foreach (var avis in film.Avis)
                {
                    Console.WriteLine(avis.Commentaire);
                }
            }
            
            //Sauvegarde du ctx => Application de la modification dans la BD
            int nbchanges = ctx.SaveChanges();
            
            Console.WriteLine("Nombre d'enregistrement modifiés ou ajoutés : " + nbchanges);

            
        }
    }
}