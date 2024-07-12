namespace AppUI;

public partial class SignupPage : ContentPage
{
	public SignupPage()
	{
		InitializeComponent();
	}

    private async void TapGestureRecognizer_Tapped_For_Login(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//Login");
    }
}