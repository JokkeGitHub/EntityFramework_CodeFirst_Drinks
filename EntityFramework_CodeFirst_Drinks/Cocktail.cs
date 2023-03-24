using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_CodeFirst_Drinks
{
    internal class Cocktail
    { 
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Ingredient> Ingredients { get; set;}
        public Container Container { get; set; }
    }
}
