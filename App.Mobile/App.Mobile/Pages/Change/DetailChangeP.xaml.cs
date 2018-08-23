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
	public partial class DetailChangeP : ContentPage
	{
        public DetailChangeP(string nroPedido)
        {
            InitializeComponent();
            BindingContext = new OrderReqDetailViewModel(nroPedido);
        }
        private void OnTapGestureRecognizerTapped(object sender, EventArgs e)
        {
            Xamarin.Forms.Application.Current.MainPage.Navigation.PushAsync(new SubMenuChangeP());
        }
        public void ButtonBackClick()
        {
            Xamarin.Forms.Application.Current.MainPage.Navigation.PopAsync();

        }

    }
}