using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

                foreach(var item in cocktails)
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

    }
}
