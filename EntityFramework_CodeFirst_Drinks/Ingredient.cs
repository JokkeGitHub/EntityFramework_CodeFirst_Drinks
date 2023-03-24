using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_CodeFirst_Drinks
{
    internal class Ingredient
    {
        public int Id { get; set; }
        public IngredientType Type { get; set; } // Remove drink type ! 
        public int Amount { get; set; }
        public Unit Unit { get; set; }
        public string Comment { get; set; }

        // add drink list
    } 
}
