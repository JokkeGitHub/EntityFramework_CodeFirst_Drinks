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
        List<Unit> unitList = new List<Unit>();
        List<Container> containerList = new List<Container>();
        List<Ingredient> ingredientList = new List<Ingredient>();
        List<Procedure> procedureList = new List<Procedure>();
        List<Cocktail> cocktailList = new List<Cocktail>();

        public MainWindow()
        {
            InitializeComponent();

            PopulateLists();

            //PopulateDB();
        }

        void PopulateLists()
        {
            PopulateUnitList();
            PopulateContainerList();
            PopulateIngredientList();
            PopulateProcedureList();
            PopulateCocktailList();
        }

        void PopulateUnitList()
        {
            unitList.Add(new Unit() { Type = "ml" });
            unitList.Add(new Unit() { Type = "segment" });
            unitList.Add(new Unit() { Type = "rim" });
            unitList.Add(new Unit() { Type = "tsp" });
            unitList.Add(new Unit() { Type = "piece" });
            unitList.Add(new Unit() { Type = "slice" });
            unitList.Add(new Unit() { Type = "dash" });
            unitList.Add(new Unit() { Type = "splash" });
        }

        void PopulateContainerList()
        {
            containerList.Add(new Container() { Type = "tall glass" });
            containerList.Add(new Container() { Type = "regular glass" });
            containerList.Add(new Container() { Type = "wide glass" });
            containerList.Add(new Container() { Type = "wine glass" });
            containerList.Add(new Container() { Type = "champagne glass" });
            containerList.Add(new Container() { Type = "cocktail glass" });
        }

        void PopulateIngredientList()
        {
            ingredientList.Add(new Ingredient() { Name = "lime juice" });
            ingredientList.Add(new Ingredient() { Name = "triplesec" });
            ingredientList.Add(new Ingredient() { Name = "tequila" });
            ingredientList.Add(new Ingredient() { Name = "salt" });
            ingredientList.Add(new Ingredient() { Name = "ice cube" });
            ingredientList.Add(new Ingredient() { Name = "lime" });
            ingredientList.Add(new Ingredient() { Name = "dark rum" });
            ingredientList.Add(new Ingredient() { Name = "orange curacao" });
            ingredientList.Add(new Ingredient() { Name = "almond syrup" });
            ingredientList.Add(new Ingredient() { Name = "maraschino cherry" });
            ingredientList.Add(new Ingredient() { Name = "fresh cream" });
            ingredientList.Add(new Ingredient() { Name = "kahlua" });
            ingredientList.Add(new Ingredient() { Name = "vodka" });
            ingredientList.Add(new Ingredient() { Name = "cachaca" });
            ingredientList.Add(new Ingredient() { Name = "caster sugar" });
            ingredientList.Add(new Ingredient() { Name = "orange juice" });
            ingredientList.Add(new Ingredient() { Name = "tomato juice" });
            ingredientList.Add(new Ingredient() { Name = "celery stick" });
            ingredientList.Add(new Ingredient() { Name = "worcestershire sauce" });
            ingredientList.Add(new Ingredient() { Name = "bourbon" });
            ingredientList.Add(new Ingredient() { Name = "orange" });
            ingredientList.Add(new Ingredient() { Name = "brown sugar" });
            ingredientList.Add(new Ingredient() { Name = "water" });
            ingredientList.Add(new Ingredient() { Name = "angostura bitters" });
            ingredientList.Add(new Ingredient() { Name = "orange peel" });
            ingredientList.Add(new Ingredient() { Name = "italian sweet vermouth" });
            ingredientList.Add(new Ingredient() { Name = "french dry vermouth" });
            ingredientList.Add(new Ingredient() { Name = "gin" });
            ingredientList.Add(new Ingredient() { Name = "olive" });
            ingredientList.Add(new Ingredient() { Name = "white rum" });
            ingredientList.Add(new Ingredient() { Name = "pink grapefruit juice" });
            ingredientList.Add(new Ingredient() { Name = "cranberry juice" });
            ingredientList.Add(new Ingredient() { Name = "cointreau" });
            ingredientList.Add(new Ingredient() { Name = "soda" });
            ingredientList.Add(new Ingredient() { Name = "cherry brandy" });
            ingredientList.Add(new Ingredient() { Name = "lemon juice" });
            ingredientList.Add(new Ingredient() { Name = "sloe gin" });
            ingredientList.Add(new Ingredient() { Name = "mint leaf" });
            ingredientList.Add(new Ingredient() { Name = "soda water" });
            ingredientList.Add(new Ingredient() { Name = "pineapple juice" });
            ingredientList.Add(new Ingredient() { Name = "coconut cream" });
            ingredientList.Add(new Ingredient() { Name = "pineapple" });
            ingredientList.Add(new Ingredient() { Name = "grapefruit juice" });
            ingredientList.Add(new Ingredient() { Name = "cola" });
            ingredientList.Add(new Ingredient() { Name = "peach puree" });
            ingredientList.Add(new Ingredient() { Name = "prosecco" });
        }

        void PopulateProcedureList()
        {

        }

        void PopulateCocktailList()
        {

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
