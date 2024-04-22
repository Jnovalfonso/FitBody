namespace FitBody.Views.Employee;

public partial class EmployeePage : ContentPage
{
    public EmployeePage()
    {
        InitializeComponent();
    }
    //NAvigating through differnet section of the page
    //going to add user
    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        Shell.Current.GoToAsync(nameof(EMadduser));
    }
    //Going to delte employe
    private void TapGestureRecognizer_Tapped_1(object sender, TappedEventArgs e)
    {
        Shell.Current.GoToAsync(nameof(EMdeleteuser));
    }
    //going to Update employe
    private void TapGestureRecognizer_Tapped_2(object sender, TappedEventArgs e)
    {
        Shell.Current.GoToAsync(nameof(Emupdateuser));
    }
    //going to view loginemploye page
    private void Back_btn_5_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(LoginEmployee));
    }
    //going to view user
    private void TapGestureRecognizer_Tapped_3(object sender, TappedEventArgs e)
    {
        Shell.Current.GoToAsync(nameof(EMviewuser));
    }
}