using FitBody.Models;

namespace FitBody.Views.Employee;

public partial class EMdeleteuser : ContentPage
{
    public EMdeleteuser()
    {
        InitializeComponent();
    }

    private void finduser_btn_2_Clicked(object sender, EventArgs e)
    {
        //Declearing variables
        string usrname;
        string passwrd;
        bool isuser;
        //Stroing the text inputted
        usrname = UserName.Text;
        passwrd = Password.Text;

        CustomerManager customerManager = new CustomerManager();
        //checking isuser true of false
        isuser = customerManager.IsCustomer(usrname, passwrd);
        //if true then deleting it
        //esles displaying no user fouund
        if (isuser == true)
        {
            customerManager.DeleteUserfromUSername(usrname);
            DisplayAlert("Sucessfull", "deleted", "ok");
        }
        else
        {
            DisplayAlert("No User Found", "Please check the username/password", "Back");
        }
        //reserting things back to sqaure one
        UserName.Text = "";
        Password.Text = "";

    }
    //For going back
    private void Back_btn_2_Clicked_1(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(EmployeePage));
    }
}