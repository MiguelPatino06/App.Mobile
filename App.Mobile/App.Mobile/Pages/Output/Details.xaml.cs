using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Mobile.Droid.Pages.Change;
using App.Mobile.Droid.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App.Mobile.Droid.Pages.Output
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Details : ContentPage
    {
        public Details(int outputId)
        {
            InitializeComponent();
            BindingContext = new OutputDetailViewModel(outputId);
        }

        private void OnTapGestureRecognizerTapped(object sender, EventArgs e)
        {
            Xamarin.Forms.Application.Current.MainPage.Navigation.PushAsync(new SubMenu());
        }

        public void ButtonBackClick()
        {
            Xamarin.Forms.Application.Current.MainPage.Navigation.PopAsync();

        }
    }
}