﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_CodeFirst_Drinks
{
    internal class CocktailContext : DbContext
    {
        public CocktailContext() : base("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CocktailsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        { }

        public DbSet<Unit> Units { get; set;}
        public DbSet<Ingredient> Ingredients { get; set;}
        public DbSet<Procedure> Procedures { get; set;}
        public DbSet<Cocktail> Cocktails { get; set;}
        public DbSet<Container> Containers { get; set;}
    }
}
