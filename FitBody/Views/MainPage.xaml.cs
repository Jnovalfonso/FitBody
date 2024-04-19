using FitBody.Models.RoutineModels;
 
using System.Formats.Tar;
 
using Microsoft.Maui.Controls;
 
namespace FitBody.Views
 
{
 
    public partial class MainPage : ContentPage
 
    {
 
        public MainPage()
 
        {
 
            InitializeComponent();
 
        }
 
        private void OnLogUserClicked(object sender, EventArgs e)
 
        {
 
            // Get the values from the Entry controls
 
            string usernameOrEmail = usernameEntry.Text.Trim();
 
            string password = passwordEntry.Text.Trim();
 
            // Check if any field is empty
 
            if (string.IsNullOrEmpty(usernameOrEmail) || string.IsNullOrEmpty(password))
 
            {
 
                // Display an error message if any field is empty
 
                DisplayAlert("Error", "Please fill in all fields", "OK");
 
                return;
 
            }
 
            // Check if the username or email contains any digits
 
            if (usernameOrEmail.Any(char.IsDigit))
 
            {
 
                // If the username or email contains digits, display an error message
 
                DisplayAlert("Error", "Username or email should not contain digits", "OK");
 
                return;
 
            }
 
            // Proceed with the login logic
 
            // ...
 
        }
 
        private void OnLogEmployeeClicked(object sender, EventArgs e)
 
        {
 
            Shell.Current.GoToAsync(nameof(LoginEmployee));
 
        }
 
        private void OnCreateAccountClicked(object sender, EventArgs e)
 
        {
 
            Shell.Current.GoToAsync(nameof(CreateCustomer));
 
        }
 
        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
 
        {
 
            string input = e.NewTextValue;
 
            // Check if the input contains any digits
 
            if (input.Any(char.IsDigit))
 
            {
 
                // If the input contains digits, display an error message
 
                DisplayAlert("Error", "Please enter a valid string", "OK");
 
                // Clear the entry text
 
                ((Entry)sender).Text = string.Empty;
 
            }
 
        }
 
    }
 
}
