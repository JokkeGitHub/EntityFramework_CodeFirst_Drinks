using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace EntityFramework_CodeFirst_Drinks
{
    internal class Database
    {
        public void PopulateDB(List<Unit> units, List<Container> containers, List<Ingredient> ingredients, List<Procedure> procedures, List<Cocktail> cocktails)
        {
            using (var context = new CocktailContext())
            {
                /*
                foreach (var item in units)
                {
                    context.Units.Add(item);
                }

                foreach (var item in containers)
                {
                    context.Containers.Add(item);
                }

                foreach (var item in ingredients)
                {
                    context.Ingredients.Add(item);
                }

                foreach (var item in procedures)
                {
                    context.Procedures.Add(item);
                }
                */

                foreach (var item in cocktails)
                {
                    context.Cocktails.Add(item);
                }

                context.SaveChanges();
            }
        }

        public void AddNewCocktailToDB(List<Unit> units, List<Container> containers, List<Ingredient> ingredients, List<Procedure> procedures, Cocktail cocktail)
        {
            using (var context = new CocktailContext())
            {
                context.Cocktails.Add(cocktail);

                context.SaveChanges();
            }
        }

        public List<Cocktail> SearchForCocktails(List<Cocktail> cocktails, string searchInput)
        {
            // get proc by ingred name id
            // get drink id

            Cocktail cocktailTemp = new Cocktail();


            List<Procedure> procedures = new List<Procedure>();

            List<int> ids = new List<int>();
            /*
            using (var context = new CocktailContext())
            {
                var query = from cocktail in cocktails
                            select cocktail;

                foreach (var cocktail in query)
                {
                    if (cocktail.Mixture.)
                    {

                    }
                }
            }*/

            using (var context = new CocktailContext())
            {
                foreach (var procedure in context.Procedures)
                {
                    if (procedure.Ingredient.Name == searchInput)
                    {
                        ids.Add(procedure.Id);
                    }
                }
            }

            using (var context = new CocktailContext())
            {
                foreach (var procedure in context.Procedures)
                {
                    procedures.Add(procedure);
                }

                foreach (var cocktail in context.Cocktails)
                {
                    if (cocktail.Name.Contains(searchInput))
                    {
                        cocktailTemp.Id = cocktail.Id;
                    }
                }
            }

            return cocktails;
        }

        public void DeleteCocktailFromDB(string cocktailToDelete)
        {
            using (var context = new CocktailContext())
            {

                // This doesn't work without cascading the removal
                foreach (var cocktail in context.Cocktails)
                {
                    if (cocktail.Name == cocktailToDelete)
                    {
                        context.Entry(cocktail).State = EntityState.Deleted;

                        //context.Cocktails.Remove(cocktail);
                    }
                }
                context.SaveChanges();
            }
        }
    }
}
