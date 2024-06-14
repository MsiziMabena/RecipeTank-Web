using RecipeTank.Models;
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
using System.Xml;

namespace RecipeTank
{
    /// <summary>
    /// Interaction logic for ViewRecipes.xaml
    /// </summary>
    public partial class ViewRecipes : Page
    {
        public ViewRecipes()
        {
            InitializeComponent();
            PopulateTable();
        }

        // Populating the table with recipes sorted by their name and their total calories.
        public void PopulateTable()
        {
            // Iterate through each recipe in StateManager's collection, ordered by name.
            foreach (Recipe recipe in StateManager.recipes.OrderBy(r => r.name))
            {
                // Creating TextBlock for each row in the table.
                TextBlock row = new TextBlock();

                // Format the text to display recipe name and total calories.
                row.Text = $"{recipe.name}\t\t--\t{recipe.CalculateTotalCalories()} kj";

                // Apply a style to the row using a predefined resource.
                row.Style = Application.Current.FindResource("tableValue") as Style;

                // Add the TextBlock to the Table's Children collection.
                NameTbl.Children.Add(row);
            }
        }
    }
}
