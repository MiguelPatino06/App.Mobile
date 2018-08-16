using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Mobile.Droid.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App.Mobile.Droid.Pages.Change
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class ClientProduct : ContentPage
    {
        public ClientProduct()
        {
            InitializeComponent();
            BindingContext = new SearchOrderReqViewModel();
        }


        private void OnTapGestureRecognizerTapped(object sender, EventArgs e)
        {
            Xamarin.Forms.Application.Current.MainPage.Navigation.PushAsync(new SubMenu());
        }


        private void OnTapGestureRecognizerTappedSearch(object sender, EventArgs e)
        {
            Xamarin.Forms.Application.Current.MainPage.Navigation.PushAsync(new SubMenu());
        }


    }
}
