using FitBody.Models;

namespace FitBody.Views.CustomerPages;

public partial class ExclusiveMember : ContentPage
{
    private Customer currentCustomer;
    public ExclusiveMember()
	{
		InitializeComponent();
	}

	private void OnFreeClicked (object sender, EventArgs e)
	{
        currentCustomer = CustomerService.Instance.CurrentCustomer;
        if (currentCustomer.IsPremium == 0) // If customer IS NOT premium
        {
            DisplayAlert("Subscription Already Added", "Your plan is already a free customer plan", "OK");
            return;
        }

        currentCustomer.IsPremium = 0;
        CustomerManager customerManager = new CustomerManager();
        customerManager.UpdateCustomer(currentCustomer);
        DisplayAlert("Subscription Added", "You are now under the Free customer plan", "OK");
    }

	private void OnPremiumClicked(object sender, EventArgs e)
	{
        currentCustomer = CustomerService.Instance.CurrentCustomer;
		if (currentCustomer.IsPremium == 1) // If customer IS premium
		{
            DisplayAlert("Subscription Already Added", "Your plan is already a premium customer plan", "OK");
			return;
        }

		currentCustomer.IsPremium = 1;
		CustomerManager customerManager = new CustomerManager();
		customerManager.UpdateCustomer(currentCustomer);
        DisplayAlert("Subscription Added", "Congratulations! You are now added to Premium subscription...", "OK");
	}
}
