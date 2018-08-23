using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Mobile.Droid.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App.Mobile.Droid.Pages.Change
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListChangeP : ContentPage
	{
        public ListChangeP()
        {
            InitializeComponent();

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            BindingContext = new SearchProductChangeViewModel();
        }

        private void OnTapGestureRecognizerTapped(object sender, EventArgs e)
        {
            Xamarin.Forms.Application.Current.MainPage.Navigation.PushAsync(new Pages.Change.SubMenuChangeP());
        }
    }
}