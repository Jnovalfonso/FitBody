using FitBody.Models;

namespace FitBody.Views.Employee;

public partial class EMviewuser : ContentPage
{
	public EMviewuser()
	{
		InitializeComponent();
	}
    //Going back
    private void Back_btn_Clicked(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync(nameof(EmployeePage));
    }
    //Binding data into a list from database
    private void Vie_customer_Clicked(object sender, EventArgs e)
    {
        CustomerManager customermanager = new CustomerManager();
        List<Customer> cusotmers = customermanager.GetAllCustomers();
        ListViewCustomer.ItemsSource = cusotmers;
    }

    
}