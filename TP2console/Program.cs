using Microsoft.EntityFrameworkCore;
using TP2console.Models.EntityFramework;

namespace TP2console;

class Program
{
    static void Main(string[] args)
    {
        using (var ctx = new FilmsDbContext())
        {
            //Désactivation du tracking => Aucun chanegement dans la base ne sera effectué
            //ctx.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;

            //Requête SELECT
            Film titanic = ctx.Films.AsNoTracking().First(f => f.Nom.Contains("Titanic"));
            
            //Modification de l'entité (dans le contexte seulement)
            titanic.Description = "Un bateau a échoué. Date : " + DateTime.Now;
            
            //Chargement de la catégorie Action
            Categorie categorieAction = ctx.Categories.First(c => c.Nom == "Action");
            Console.WriteLine("Categorie : " + categorieAction.Nom);
            Console.WriteLine("Films : ");
            //Chargement des films de la catégorie Action.
            foreach (var film in ctx.Films.Where(f => f.IdcategorieNavigation.Nom ==
                                                      categorieAction.Nom).ToList())
            {
                Console.WriteLine(film.Nom);
            }
            
            //Sauvegarde du ctx => Application de la modification dans la BD
            int nbchanges = ctx.SaveChanges();
            
            Console.WriteLine("Nombre d'enregistrement modifiés ou ajoutés : " + nbchanges);

            
        }
    }
}