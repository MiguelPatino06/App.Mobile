using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Mobile.Droid.ViewModels;
using App.Mobile.Droid.Pages.Reception;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App.Mobile.Droid.Pages.Reception
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OderList : ContentPage
    {
        public OderList(string code, string provider)
        {
            InitializeComponent();
            this.BindingContext = new OrderProviderViewModel(code, provider);
        }

        private void OnTapGestureRecognizerTapped(object sender, EventArgs e)
        {
            Xamarin.Forms.Application.Current.MainPage.Navigation.PushAsync(new Search());
        }
    }
}