using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Mobile.Droid.Models;
using App.Mobile.Droid.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App.Mobile.Droid.Pages.Reception
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrderPage : ContentPage
    {
        private List<OrderTShirt> _code { get; set; }
        private List<ViewOrder> _orders { get; set; }
        private int CountPage { get; set; }

        public OrderPage(List<OrderTShirt> codes, List<ViewOrder> orders)
        {
            CountPage = 0;
            _code = codes;
            _orders = orders;
            InitializeComponent();
        }

        protected override void OnAppearing()
        {

            base.OnAppearing();
            CountPage += 1;

            GetOrderPage();
            EntBarcode.Text = "";
            EntBarcode.Focus();
        }

        //private void OnTapGestureRecognizerTapped(object sender, EventArgs e)
        //{
        //    Xamarin.Forms.Application.Current.MainPage.Navigation.PushAsync(new Search());
        //}

        protected override bool OnBackButtonPressed()
        {
            Device.BeginInvokeOnMainThread(async () => {
                var result = await this.DisplayAlert("TSHIRT!", "Desea Salir?", "SI", "NO");
                if (result) await this.Navigation.PopAsync();
            });

            return true;
        }




        private void GetOrderPage()
        {
            this.BindingContext = CountPage == 1 ? new OrderViewModel(_code, _orders) : new OrderViewModel(_code, null);
        }

        //private void PickerWarehouse_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    List<ViewOrder> mvm = new List<ViewOrder>();
        //    var xx = PickerWarehouseInit.SelectedItem;
        //    ObservableCollection<ViewOrder> _viewOrders = new ObservableCollection<ViewOrder>();

        //    var xxx = sender as SelectedItemChangedEventArgs;

        //    foreach (var items in OrderListView.ItemsSource)
        //    {
        //        mvm.Add(new ViewOrder {OrderValue1 = xx.ToString() });
        //    }

        //    var changeList = mvm.Select(a => new ViewOrder()
        //    {
        //        OrderValue1 = xx.ToString()
        //    }).ToList();

        //    this.BindingContext = mvm.to

        //    OrderListView.ItemsSource = new ObservableCollection<ViewOrder>(changeList);


        //}
    }
}