using Xamarin.Forms;

namespace AppNut
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();
			MainPage = new HomeTab();
			// MainPage = new NavigationPage(new AppNutPage());
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
