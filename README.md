RecipeTank-Web
RecipeTank-Web is the graphical, WPF-based evolution of the RecipeTank ecosystem. It brings the core recipe management and scaling logic into a modern desktop interface with clear layouts and visual feedback.
Overview
RecipeTank-Web lets users:
* Create and manage recipes through a user-friendly WPF interface
* Add ingredients and configure quantities with intuitive on-screen controls
* Dynamically scale recipes up or down using built-in scaling logic
* Visualize recipe data using a Pie Chart for a quick, at-a-glance breakdown
This project builds on the core logic from the RecipeTank-Blueprint console app and showcases how that foundation can be turned into a polished, interactive desktop experience.
Key Features
* User-friendly WPF interface
Clean, structured windows and controls built in XAML make it easy to navigate, input data, and view results without needing to use the console.
* Intuitive recipe creation
Users can create a recipe, define ingredients, and set quantities and units directly from the UI, with clearly labeled fields and buttons.
* Dynamic scaling logic
The same scaling concept from the console version is implemented in the UI. Users can apply scaling factors (for example 0.5, 2, or 3) to automatically update ingredient quantities.
* Visual data via Pie Chart
A Pie Chart presents a visual breakdown of the recipe ingredients, helping users quickly see relative proportions at a glance.
* Integrated experience
All operations (create, view, scale, and visualize) are accessible from a single main window, minimizing friction and keeping the workflow straightforward.
Setup and Running (Visual Studio 2022)
* Clone the repository
* Use git clone to copy the RecipeTank-Web repository to your local machine.
* Open in Visual Studio 2022
* Open Visual Studio 2022.
* Go to File > Open > Project/Solution and select the RecipeTank-Web solution file (.sln).
* Restore and build
* Ensure the correct startup project is selected (the WPF application project).
* Build the solution using Build > Build Solution.
* Run the application
* Press F5 (or click Start) in Visual Studio to launch the WPF app.
* The main window will open, allowing you to create recipes, add ingredients, scale them, and view the Pie Chart.
Technical Highlights
* WPF and XAML-based UI
The interface is built with WPF using XAML to define windows, layouts, controls, and the Pie Chart. This separation of UI definition and logic makes the interface easier to maintain and extend.
* C# backend logic
Recipe models, ingredient handling, and scaling logic are implemented in C#. The code-behind and supporting classes coordinate user actions from the UI and update the displayed data.
* Recipe and ingredient model
Recipes and ingredients are represented as structured objects (for example, name, quantity, and unit). These models are used both for display and for applying scaling operations.
* Dynamic scaling implementation
When a scaling factor is applied, the application recalculates ingredient quantities and updates the UI accordingly. This ties the original console logic to a richer, interactive presentation layer.
* Data visualization with Pie Chart
The Pie Chart is bound to the recipe data to provide a visual representation of ingredient proportions. As recipe data changes, the chart reflects the updated state.
RecipeTank-Web demonstrates how a console-based recipe engine can be transformed into a more complete, user-facing product with a polished WPF interface and visual feedback.
