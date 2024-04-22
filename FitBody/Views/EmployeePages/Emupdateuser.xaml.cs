using FitBody.Models;

namespace FitBody.Views.Employee;

public partial class Emupdateuser : ContentPage
{
	public Emupdateuser()
	{
		InitializeComponent();
	}

    private void finduser_btn_Clicked(object sender, EventArgs e)
    {
		//decelaring variables
		string usrname;
		string passwrd;
		bool isuser;
		//Stroing the text inputed in varibles
		usrname = UserName.Text;
		passwrd = Password.Text;
		CustomerManager findingcustomer = new CustomerManager();
		//checking wether the user even exist or not
		isuser = findingcustomer.IsCustomer(usrname, passwrd);
		//if true then navigating to found user page
		//Else showing no user found
		if (isuser == true) 
		{
			Shell.Current.GoToAsync(nameof(foundUser));
		}
		else
		{
			DisplayAlert("No User Found", "Please check the user name and password", "Back");
		}
		UserName.Text = "";
		Password.Text = "";
    }
	//goingback
    private void Back_btn_Clicked_1(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync(nameof(EmployeePage));
    }
}