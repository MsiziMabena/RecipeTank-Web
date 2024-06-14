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
    // Logic for CreateRecipe.xaml
    public partial class CreateRecipe : Page
    {
        // Declaring a recipe object
        public Recipe recipe;

        // Constructor for the CreateRecipe class
        public CreateRecipe()
        {
            InitializeComponent();
            recipe = new Recipe();
        }

        //Adding an Ingredient to the list
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddIngredient_Click(object sender, RoutedEventArgs e)
        {
            // Clearing any previous error message
            ErrorMessage.Content = "";
            try
            {
                // Collecting Data from user input
                string name = TB_IngridentName.Text;
                int quantity = Convert.ToInt32(TB_Quantity.Text);
                string measure = TB_UnitOfMes.Text;
                int calories = Convert.ToInt32(TB_Calories.Text);
                string foodGroup = CB_FoodGroup.Text;

                // Adding the new ingredient to the recipe
                recipe.ingredients.Add(new Ingredient(name, quantity, measure, calories, foodGroup));

                // Update the user interface with the new ingredient
                PopulateTable();

                // Reset the input fields for ingredients
                ResetIngredient();
            }
            catch
            {
                // Display error message if any exception occurs
                ErrorMessage.Content = "An Error Occured - Please ensure inserted Ingredient is correct";
            }
        }

        // Adding Step button action handler
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddStep_Click(object sender, RoutedEventArgs e)
        {
            // Clearing any previous error message
            ErrorMessage.Content = "";
            try
            {
                // Add the step to the recipe
                recipe.steps.Add(TB_StepDesc.Text);

                // Update the UI with the new step
                PopulateTable();

                // Clear the step description input field
                TB_StepDesc.Text = "";
            }
            catch
            {
                // Display error message if an exception occurs
                ErrorMessage.Content = "An Error Occured - Please ensure inputted Step is correct";
            }
        }

        // Adding Recipe button handler
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddRecipe_Click(object sender, RoutedEventArgs e)
        {
            // Clear any previous error message
            ErrorMessage.Content = "";
            try
            {
                // Collecting the recipe details from user input
                string name = TB_Name.Text;
                string desc = TB_Dresc.Text;

                // Adding the details to the recipe
                recipe.AddDetails(name, desc);

                // Ensuring there are Ingredients and Steps in the recipe
                if (recipe.ingredients.Count > 0 || recipe.steps.Count > 0)
                {
                    // Adding the recipe to the state manager
                    StateManager.recipes.Add(recipe);

                    // Display success message
                    SuccessMessage.Content = "Your recipe has been finally added";

                    // Resetting the UI for next addition
                    ResetRec();
                    ResetIngredient();
                    InputTable.Children.Clear();

                    // Creating a new recipe object
                    recipe = new Recipe();
                    return;
                }

                // Display error message if no ingredients or steps are present
                ErrorMessage.Content = "Please Add A Step And Ingredient to Continue";
            }
            catch
            {
                // Display error message if an exception occurs
                ErrorMessage.Content = "An Error Occured - Please ensure inserted Recipe is correct";
            }
        }


        // Populating the table with ingredients and steps
 
        public void PopulateTable()
        {
            // Clearing user interface
            ErrorMessage.Content = "";
            InputTable.Children.Clear();

            // Display the ingredients if there are any are present
            if (recipe.ingredients.Count > 0)
            {
                // Creates a Label for the ingredients list
                Label ingreHeader = new Label();
                ingreHeader.Content = "Ingredients Added";
                InputTable.Children.Add(ingreHeader);

                // Looping through ingredients and adding them to the table 
                for (int i = 0; i < recipe.ingredients.Count; i++)
                {
                    Label value = new Label();
                    value.Content = $"{i + 1} - {recipe.ingredients[i].name} {recipe.ingredients[i].quantity}{recipe.ingredients[i].unitOfMesure} ";
                    InputTable.Children.Add(value);
                }
            }

            // Display the steps if any are present
            if (recipe.steps.Count > 0)
            {
                Label stepsHeader = new Label();
                stepsHeader.Content = "Steps Added";
                InputTable.Children.Add(stepsHeader);

                // Looping through steps and adding them to the table
                for (int i = 0; i < recipe.steps.Count; i++)
                {
                    Label value = new Label();
                    value.Content = $"{i + 1} - {recipe.steps[i]}";
                    InputTable.Children.Add(value);
                }
            }
        }

        //Handles the resetting of user interface for Recipe
        private void ResetRec()
        {
            // Clearing the input fields for the recipe details
            TB_Name.Text = "";
            TB_Dresc.Text = "";
            TB_StepDesc.Text = "";
        }

        // Handles the resetting of User interface for Ingredients
        private void ResetIngredient()
        {
            // Clearing the input fields for the ingredients
            TB_IngridentName.Text = "";
            TB_Quantity.Text = "";
            TB_UnitOfMes.Text = "";
            TB_Calories.Text = "";
        }
    }
}
