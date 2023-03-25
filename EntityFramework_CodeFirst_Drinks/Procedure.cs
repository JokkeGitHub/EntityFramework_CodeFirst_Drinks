using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_CodeFirst_Drinks
{
    internal class Procedure
    {
        public int Id { get; set; }
        public double Amount { get; set; }
        public Unit Unit { get; set; } // Enum? 
        public Ingredient Ingredient { get; set; }
        public string Comment { get; set; }
    }
}
