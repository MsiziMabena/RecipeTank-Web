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
using System.Windows.Shapes;

namespace RecipeTank
{
    /// <summary>
    /// Interaction logic for DeleteRecipe.xaml
    /// </summary>
    public partial class DeleteRecipe : Page
    {
        public DeleteRecipe()
        {
            InitializeComponent();
            // Populating the ComboBox with recipes when the page is initialized
            PopulateCB();
        }

        /// Populateing the ComboBox with the list of recipes from the StateManager
        public void PopulateCB()
        {
            // Set the item source for the ComboBox to the list of recipes
            SelectRecCB.ItemsSource = StateManager.recipes;
            // Display the name property of each recipe in the ComboBox
            SelectRecCB.DisplayMemberPath = "name";
        }

        /// Handles the click event of the delete button to remove the selected recipe

        private void deleteRecipe_Click(object sender, RoutedEventArgs e)
        {
            // Get the selected recipe from the ComboBox
            Recipe selectedRecipe = (Recipe)SelectRecCB.SelectedItem;

            // Remove the selected recipe from the StateManager
            StateManager.RemoveRecipe(selectedRecipe);

            // Refresh the page to update the ComboBox and reflect the removal of the recipe
            this.NavigationService.Navigate(new DeleteRecipe());
        }
    }
}
