namespace FitBody.Views;

public partial class Create : ContentPage
{
	public Create()
	{
		InitializeComponent();

	}

    private void OnBackClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }
}