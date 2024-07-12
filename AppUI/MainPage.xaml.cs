namespace AppUI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnMoveClick(object sender, EventArgs e)
        {
            // Navigate to a new page
            Navigation.PushAsync(new LoginPage());
        }
    }

}
