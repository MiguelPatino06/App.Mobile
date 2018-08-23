
using App.Mobile.Droid.Pages;
using Xamarin.Forms;

namespace App.Mobile.Droid
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            MainPage = new NavigationPage(new MainMenu("USER01"));
            //MainPage = new NavigationPage(new MainMenu());
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
