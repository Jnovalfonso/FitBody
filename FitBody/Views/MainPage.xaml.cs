using System.Formats.Tar;

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
            
        }

        private void OnLogEmployeeClicked(object sender, EventArgs e)
        {

        }

        private void OnCreateAccountClicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync(nameof(CreateCustomer));
        }
    }

}
