using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Mobile.Droid.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App.Mobile.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : ContentPage
    {
        public Menu(string user)
        {
            User = user;
            InitializeComponent();
            LoadMenu();
            ListMenu.ItemsSource = MenuItems;
        }

        private void OnTapGestureRecognizerTapped(object sender, EventArgs e)
        {
            //Xamarin.Forms.Application.Current.MainPage.Navigation.PushAsync(new Config());
        }

        public ObservableCollection<MenuItemViewModel> MenuItems { get; set; }

        public string User { get; set; }


        public void LoadMenu()
        {

            MenuItems = new ObservableCollection<MenuItemViewModel>();

            ImageSource.FromFile("@drawable/Logo.png");

            MenuItems.Add(new MenuItemViewModel
            {
                Id = 1,
                Icon = "@drawable/Recepcion.png",
                Name = "Recepcion",
                Page = "Pages/Recepcion/Search",
                UserLogin = User
            });
            MenuItems.Add(new MenuItemViewModel
            {
                Id = 2,
                Icon = "@drawable/Count.png",
                Name = "Conteo",
                Page = "Pages/Count/PlanList",
                UserLogin = User
            });
            MenuItems.Add(new MenuItemViewModel
            {
                Id = 4,
                Icon = "@drawable/warehousetranfer.png",
                Name = "Transferencia entre Bodegas",
                Page = "Pages/WarehouseTransfer/SubMenu",
                UserLogin = User
            });
            MenuItems.Add(new MenuItemViewModel
            {
                Id = 5,
                Icon = "@drawable/exit.png",
                Name = "Salida a Producción",
                Page = "Pages/Count/PlanList"
            });
            MenuItems.Add(new MenuItemViewModel
            {
                Id = 6,
                Icon = "@drawable/cambio.png",
                Name = "Cambio Producto",
                Page = "Pages/Transaction/ClientProduct"
            });
            //MenuItems.Add(new MenuItemViewModel
            //{
            //    Id = 3,
            //    Icon = "@drawable/Transaction.png",
            //    Name = "Transacion",
            //    Page = "Pages/Recepcion/Transaction"
            //});
            //MenuItems.Add(new MenuItemViewModel
            //{
            //    Id = 16,
            //    Icon = "@drawable/exit.png",
            //    Name = "Salir",
            //    Page = "Pages/Recepcion/Count"
            //});
        }


        void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
           => ((ListView)sender).SelectedItem = null;

    }
}