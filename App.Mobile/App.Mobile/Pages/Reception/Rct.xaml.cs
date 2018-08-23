using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Mobile.Droid.Models;
using App.Mobile.Droid.ViewModels;
using App.Mobile.Droid.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App.Mobile.Droid.Pages.Reception
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Rct : ContentPage
    {
        public Rct(string ordercode, RctExtendModel rct)
        {
            InitializeComponent();
            BindingContext = new RctViewModel(ordercode, rct);
        }

        private void OnTapGestureRecognizerTapped(object sender, EventArgs e)
        {
            Xamarin.Forms.Application.Current.MainPage.Navigation.PushAsync(new MainMenu(string.Empty));
        }
    }
}