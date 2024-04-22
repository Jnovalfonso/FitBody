using FitBody.Models;
using FitBody.Views.Employee;

namespace FitBody.Views;

public partial class LoginEmployee : ContentPage
{
    public LoginEmployee()
    {
        InitializeComponent();
    }

    private void OnLoginClicked(object sender, EventArgs e)
    {
        //declaring varibles
        //stroing the inputed value into text
        string email = EmployeEmail.Text;
        string password = EmployeePassword.Text;
        bool isEmployee;
        EmployeeManager employeeManager = new EmployeeManager();
        //Checking eather the crediants are right or wrong
        isEmployee = employeeManager.IsEmployee(email, password);
        if (isEmployee == true)
        {
            Shell.Current.GoToAsync(nameof(EmployeePage));
        }
        else
        {
            DisplayAlert("Invalid Password/email", "Error", "Ok");
        }
    }
    //Going back


    private void BKACBRN_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }
}