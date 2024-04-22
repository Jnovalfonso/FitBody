namespace FitBody.Views.Employee;

public partial class EmployeManager : ContentPage
{
	public EmployeManager()
	{
		InitializeComponent();
	}
    //going back
    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        Shell.Current.GoToAsync(nameof(EMadduser));
    }
}