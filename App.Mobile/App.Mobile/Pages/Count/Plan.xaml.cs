using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Mobile.Droid.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App.Mobile.Droid.Pages.Count
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Plan : ContentPage
    {
        public int _id { get; set; }
        public string _user { get; set; }

        public Plan(int id, string user)
        {
            _user = user;
            _id = id;
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            GetPlan();
            EntBarcode.Text = "";
            EntBarcode.Focus();
        }


        void GetPlan()
        {
            BindingContext = new CountViewModel(_id, _user);
        }
        //async Task GetPlan()
        //{
        //    await Task.Run(() =>
        //    {
        //        Device.BeginInvokeOnMainThread(() =>
        //        {
        //            BindingContext = new CountViewModel(_id);
        //        });
        //    });            
        //}

        // OnTapPrevPage
        ////private void OnTapGestureRecognizerTapped(object sender, EventArgs e)
        ////{
        ////    Xamarin.Forms.Application.Current.MainPage.Navigation.PopAsync();
        ////}

        private void OnTapPrevPage(object sender, EventArgs e)
        {
            Xamarin.Forms.Application.Current.MainPage.Navigation.PopAsync();
        }

        private void OnTapNextPage(object sender, EventArgs e)
        {
            Xamarin.Forms.Application.Current.MainPage.Navigation.PushAsync(new PlanList(_user));
        }
    }
}