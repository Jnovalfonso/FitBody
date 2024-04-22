using FitBody.Models;

namespace FitBody.Views.Employee;

public partial class foundUser : ContentPage
{
	public foundUser()
	{
		InitializeComponent();
        DisplayAlert("NOTE", "YOU CANNOT CHANGE THE USERNAME GIVEN BY THE SYSTEM, KINDLY USE THE SAME USERNAME", "OK");
	}
    //going back
    private void Back_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(EmployeePage));
    }
    private void Adduserbtn_Clicked(object sender, EventArgs e)
    {
        //declaring variables
        string usrname;
        string name;
        string email;
        string password;
        int age;
        string gender;
        int height;
        int weight;
        bool ispreium;
        //storing the inputed text into vairbles
        usrname = UserName.Text;
        name = Name.Text;
        email = Email.Text;
        password = Password.Text;
        age = Convert.ToInt32(Age.Text);
        gender = Gender.Text;
        height = Convert.ToInt32(Height.Text);
        weight = Convert.ToInt32(Weight.Text);
        ispreium = Convert.ToBoolean(Premium.Text);
        //udapting the info of the user
        Customer updatecusotmer = new Customer()
        {
            Name = name,
            Email = email,
            Password = password,
            Age = age,
            Gender = gender,
            Height = height,
            Username = usrname,
            Weight = weight
        };
        //Upadting the user
        CustomerManager updcus = new CustomerManager();
        updcus.UpdateCustomer(updatecusotmer);
        DisplayAlert("succesfull", "userupdated", "ok");
    }

    
}