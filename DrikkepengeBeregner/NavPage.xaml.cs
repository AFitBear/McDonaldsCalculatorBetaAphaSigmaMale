namespace DrikkepengeBeregner;

public partial class NavPage : ContentPage
{
	public NavPage()
	{
		InitializeComponent();
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		App.Current.MainPage = new NavigationPage(new MainPage());
	}
}