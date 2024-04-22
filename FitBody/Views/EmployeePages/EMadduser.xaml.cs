using FitBody.Models;
using FitBody.Views.Employee;

namespace FitBody.Views;

public partial class EMadduser : ContentPage
{
    public EMadduser()
    {
        InitializeComponent();
        //Firstly displaying the adminstrative that it is important to fill in all the feild
        DisplayAlert("Note", "Everything is required to filled", "ok");
    }
    private void Back_Clicked(object sender, EventArgs e)
    {
        //Going back
        Shell.Current.GoToAsync(nameof(EmployeePage));
    }



    private void Adduserbtn_Clicked(object sender, EventArgs e)
    {
        //Declaeing avraibles to store the text inputed by the adminstrative
        string usrname;
        string name;
        string email;
        string password;
        int age;
        string gender;
        int height;
        int weight;
        bool ispreium;
        //Catign expection to check if the folloowing feils are in right order
        try
        {
            if (!string.IsNullOrWhiteSpace(Age.Text))
                age = int.Parse(Age.Text);
            if (!string.IsNullOrWhiteSpace(Height.Text))
                height = int.Parse(Height.Text);
            if (!string.IsNullOrWhiteSpace(Weight.Text))
                weight = int.Parse(Weight.Text);
        }
        catch (FormatException)
        {
            DisplayAlert("Invalid Input", "Please enter valid numeric values for Age, Height, and Weight", "OK");
            return;
        }
        try
        {
            if (!string.IsNullOrWhiteSpace(Premium.Text))
                ispreium = bool.Parse(Premium.Text);
        } catch (FormatException)
        {
            DisplayAlert("Invalid Input", "Ispreium Can Either be true or False","Ok");
            return;
        }
        //After that storing the input
        usrname = UserName.Text;
        name = Name.Text;
        email = Email.Text;
        password = Password.Text;
        age = Convert.ToInt32(Age.Text);
        gender = Gender.Text;
        height = Convert.ToInt32(Height.Text);
        weight = Convert.ToInt32(Weight.Text);
        ispreium = Convert.ToBoolean(Premium.Text);
        //checking few more case
        if (string.IsNullOrWhiteSpace(usrname) || string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) ||
         string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(gender))
        {
            DisplayAlert("Missing Information", "Please fill in all required fields.", "OK");
            return;
        }
        //Finalyy creating the user and then add it
        else
        {
            Customer newcustomer = new Customer()
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

            CustomerManager customerManager = new CustomerManager();
            //Checking if the user already exist
            if(customerManager.IsCustomer(usrname, password) == true)
            {
                DisplayAlert("Already Exist", "The User name already Exist, try another Username", "OK");
                return;
            };
            customerManager.AddCustomer(newcustomer);
            DisplayAlert("Succedfully Added", "new User added", "ok");
            //Reseting everything
            UserName.Text = "";
            Name.Text = "";
            Email.Text = "";
            Age.Text = "";
            Password.Text = "";
            Age.Text = "";
            Gender.Text = "";
            Height.Text = "";
            Weight.Text = "";
            Premium.Text = "";
        }
    }
}