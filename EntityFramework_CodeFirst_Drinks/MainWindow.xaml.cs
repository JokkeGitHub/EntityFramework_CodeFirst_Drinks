using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EntityFramework_CodeFirst_Drinks
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            PopulateDB();
        }

        void PopulateDB()
        {
            using (var context = new CocktailContext())
            {
                var unit1 = new Unit() { Type = "ml" };
                var unit2 = new Unit() { Type = "cl" };
                var unit3 = new Unit() { Type = "tsp" };
                var unit4 = new Unit() { Type = "slice" };
                var unit5 = new Unit() { Type = "piece" };
                var unit6 = new Unit() { Type = "segment" };
                var unit7 = new Unit() { Type = "rim" };
                var unit8 = new Unit() { Type = "dash" };
                context.Units.Add(unit1);
                context.Units.Add(unit2);
                context.Units.Add(unit3);
                context.Units.Add(unit4);
                context.Units.Add(unit5);
                context.Units.Add(unit6);
                context.Units.Add(unit7);
                context.Units.Add(unit8);

                var container1 = new Container() { Type = "Tall glass" };
                var container2 = new Container() { Type = "Glass" };
                var container3 = new Container() { Type = "Cocktail glass" };
                var container4 = new Container() { Type = "Wide glass" };
                context.Containers.Add(container1);
                context.Containers.Add(container2);
                context.Containers.Add(container3);
                context.Containers.Add(container4);

                var ingredientType1 = new IngredientType() { Name = "Vodka" };
                var ingredientType2 = new IngredientType() { Name = "Lime" };
                var ingredientType3 = new IngredientType() { Name = "Tomato juice" };
                var ingredientType4 = new IngredientType() { Name = "Water" };
                var ingredientType5 = new IngredientType() { Name = "Bourbon" };
                var ingredientType6 = new IngredientType() { Name = "Soda" };
                var ingredientType7 = new IngredientType() { Name = "Gin" };
                var ingredientType8 = new IngredientType() { Name = "Lemon" };
                var ingredientType9 = new IngredientType() { Name = "Ice cube" };
                var ingredientType10 = new IngredientType() { Name = "Salt" };
                var ingredientType11 = new IngredientType() { Name = "Sugar" };
                context.IngredientTypes.Add(ingredientType1);
                context.IngredientTypes.Add(ingredientType2);
                context.IngredientTypes.Add(ingredientType3);
                context.IngredientTypes.Add(ingredientType4);
                context.IngredientTypes.Add(ingredientType5);
                context.IngredientTypes.Add(ingredientType6);
                context.IngredientTypes.Add(ingredientType7);
                context.IngredientTypes.Add(ingredientType8);
                context.IngredientTypes.Add(ingredientType9);
                context.IngredientTypes.Add(ingredientType10);
                context.IngredientTypes.Add(ingredientType11);

                var cocktail1 = new Cocktail() { Name = "Bloody Ding Dong", Container = new Container() { }, };

                context.SaveChanges();
            }
        }

        private void BtnSearchInput_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
