﻿using System;
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
        Database database = new Database();

        List<Unit> unitList = new List<Unit>();
        List<Container> containerList = new List<Container>();
        List<Ingredient> ingredientList = new List<Ingredient>();
        List<Procedure> procedureList = new List<Procedure>();
        List<Cocktail> cocktailList = new List<Cocktail>();

        List<Procedure> tempMixtureList = new List<Procedure>();
        List<Cocktail> tempCocktailList = new List<Cocktail>();

        public MainWindow()
        {
            InitializeComponent();

            PopulateLists();

            AddDataToUI();

            AddDrinksToDB();
        }

        void PopulateLists()
        {
            PopulateUnitList();
            PopulateContainerList();
            PopulateIngredientList();
            //PopulateProcedureList();
            PopulateCocktailList();
        }

        #region Populate Lists

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
            unitList.Add(new Unit() { Type = "section" });
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

        void PopulateCocktailList()
        {
            cocktailList.Add(new Cocktail()
            {
                Name = "Margarita",
                Container = containerList[2],
                Mixture = new List<Procedure>() { new Procedure() {
                                                        Amount = 60,
                                                        Unit = unitList[0],
                                                        Ingredient = ingredientList[0],
                                                        Comment = ""
                                                  },
                                                  new Procedure() {
                                                        Amount = 30,
                                                        Unit = unitList[0],
                                                        Ingredient = ingredientList[1],
                                                        Comment = ""
                                                  },
                                                  new Procedure() {
                                                        Amount = 60,
                                                        Unit = unitList[0],
                                                        Ingredient = ingredientList[2],
                                                        Comment = ""
                                                  },
                                                  new Procedure() {
                                                        Amount = 1,
                                                        Unit = unitList[2],
                                                        Ingredient = ingredientList[3],
                                                        Comment = ""
                                                  },
                                                  new Procedure() {
                                                        Amount = 1,
                                                        Unit = unitList[4],
                                                        Ingredient = ingredientList[4],
                                                        Comment = "crushed"
                                                  },
                                                  new Procedure() {
                                                        Amount = 1,
                                                        Unit = unitList[1],
                                                        Ingredient = ingredientList[5],
                                                        Comment = ""
                                                  }
                }
            });

            cocktailList.Add(new Cocktail()
            {
                Name = "Mai Tai",
                Container = containerList[2],
                Mixture = new List<Procedure>() { new Procedure() {
                                                        Amount = 50,
                                                        Unit = unitList[0],
                                                        Ingredient = ingredientList[6],
                                                        Comment = ""
                                                  },
                                                  new Procedure() {
                                                        Amount = 15,
                                                        Unit = unitList[0],
                                                        Ingredient = ingredientList[7],
                                                        Comment = ""
                                                  },
                                                  new Procedure() {
                                                        Amount = 10,
                                                        Unit = unitList[0],
                                                        Ingredient = ingredientList[0],
                                                        Comment = ""
                                                  },
                                                  new Procedure() {
                                                        Amount = 60,
                                                        Unit = unitList[0],
                                                        Ingredient = ingredientList[8],
                                                        Comment = ""
                                                  },
                                                  new Procedure() {
                                                        Amount = 1,
                                                        Unit = unitList[8],
                                                        Ingredient = ingredientList[5],
                                                        Comment = ""
                                                  },
                                                  new Procedure() {
                                                        Amount = 1,
                                                        Unit = unitList[4],
                                                        Ingredient = ingredientList[9],
                                                        Comment = ""
                                                  },
                                                  new Procedure() {
                                                        Amount = 1,
                                                        Unit = unitList[1],
                                                        Ingredient = ingredientList[5],
                                                        Comment = ""
                                                  }
                }
            });
        }

        #endregion

        void AddDataToUI()
        {
            foreach (var item in unitList)
            {
                ComboBoxUnitList.Items.Add(item.Type);
            }

            foreach (var item in containerList)
            {
                ComboBoxGlassList.Items.Add(item.Type);
            }

            foreach (var item in ingredientList)
            {
                ComboBoxIngredientList.Items.Add(item.Name);
            }

            UpdateDrinkList();
        }

        void UpdateDrinkList()
        {
            ListViewDrinkNames.Items.Clear();

            foreach (var item in cocktailList)
            {
                ListViewDrinkNames.Items.Add(new { Column1 = item.Name });
            }
        }

        void AddDrinksToDB()
        {
            database.PopulateDB(unitList, containerList, ingredientList, procedureList, cocktailList);
        }

        private void BtnSearchInput_KeyUp(object sender, KeyEventArgs e)
        {
            ListViewDrinkNames.Items.Clear();

            tempCocktailList = database.SearchForCocktails(tempCocktailList, TextBoxSearchInput.Text);

            foreach (var item in tempCocktailList)
            {
                ListViewDrinkNames.Items.Add(new { Column1 = item.Name });
            }

            /*
            for (int i = 0; i < cocktailList.Count; i++)
            {
                for (int j = 0; j < cocktailList[i].Mixture.Count; j++)
                {
                    if (cocktailList[i].Mixture[j].Ingredient.Name.Contains(TextBoxSearchInput.Text.ToLower()))
                    {
                        ListViewDrinkNames.Items.Add(new { Column1 = cocktailList[i].Name });
                        j = cocktailList[i].Mixture.Count + 1;
                    }
                }
            }*/
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            Clear();
        }

        void Clear()
        {
            TextBoxDrinkName.Clear();
            ListViewProcedureList.Items.Clear();
            tempMixtureList.Clear();
            TextBoxAmount.Clear();
            TextBoxComment.Clear();
        }

        private void BtnAddIngredient_Click(object sender, RoutedEventArgs e)
        {
            Procedure procedure = new Procedure();
            procedure.Amount = Convert.ToDouble(TextBoxAmount.Text);

            foreach (var item in unitList)
            {
                if (item.Type == ComboBoxUnitList.Text)
                {
                    procedure.Unit = item;
                }
            }

            foreach (var item in ingredientList)
            {
                if (item.Name == ComboBoxIngredientList.Text)
                {
                    procedure.Ingredient = item;
                }
            }

            procedure.Comment = TextBoxComment.Text;

            ListViewProcedureList.Items.Add(new { Column1 = procedure.Amount, Column2 = procedure.Unit.Type, Column3 = procedure.Ingredient.Name, Column4 = procedure.Comment });
            tempMixtureList.Add(procedure);
        }

        private void BtnCreateDrink_Click(object sender, RoutedEventArgs e)
        {
            Cocktail cocktail = new Cocktail();

            cocktail.Name = TextBoxDrinkName.Text;

            cocktail.Mixture = new List<Procedure>();

            foreach (var item in tempMixtureList)
            {
                cocktail.Mixture.Add(item);
            }

            foreach (var item in containerList)
            {
                if (item.Type == ComboBoxGlassList.Text)
                {
                    cocktail.Container = item;
                }
            }

            cocktailList.Add(cocktail);

            UpdateDrinkList();

            database.AddNewCocktailToDB(unitList, containerList, ingredientList, procedureList, cocktail);

            Clear();
        }

        private void BtnDeleteDrink_Click(object sender, RoutedEventArgs e)
        {
            database.DeleteCocktailFromDB(TextBoxDrinkName.Text);
        }
    }
}
