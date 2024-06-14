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
    /// This is the main window of the whole application.
    
    public partial class MainWindow : Window
    {
        // Constructor for the MainWindow class
        public MainWindow()
        {
            InitializeComponent(); // Initializing all the components defined in the XAML file
        }

        // This is the event handler for the "AddRecipe" button click event
        private void AddRecipe_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new CreateRecipe());//To navigate the CreateRecipe page's main frame
        }

        // This is the event handler for the "DisplayRecipe" button click event
        private void DisplayRecipe_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ViewRecipes());
        }

        // This is the event handler for the "ScaleRecipe" button click event
        private void ScaleRecipe_Click(object sender, RoutedEventArgs e)
        {
           
            MainFrame.Navigate(new ScaleRecipe());
        }

        // This is the event handler for the PieChart button click event
        private void PieChart_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new PieChart());// To navigate the PieChart page's main frame
        }

        // This is the event handler for the DeleteRecipe button click event
        private void DeleteRecipe_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new DeleteRecipe()); //To navigate the DeleteRecipe page's main frame
        }

        // Event handler for when the main frame has navigated to a new page
        private void MainFrame_Navigated(object sender, NavigationEventArgs e)
        {
            // This is a placeholder for any actions that need to be taken after the navigation occurs
        }
    }
}


