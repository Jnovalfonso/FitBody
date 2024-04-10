using FitBody.Models;

namespace FitBody.Views;

public partial class CreateCustomer : ContentPage
{
	public CreateCustomer()
	{
		InitializeComponent();
	}

    private void OnCreateClicked(object sender, EventArgs e)
    {
        Customer newCustomer = new Customer(username.Text, name.Text, email.Text, password.Text);
        var navigationParameter = new ShellNavigationQueryParameters { { "customer", newCustomer} };
        Shell.Current.GoToAsync(nameof(CreateCustomerDetails),navigationParameter);

    }

    private void OnBackClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");

    }

}