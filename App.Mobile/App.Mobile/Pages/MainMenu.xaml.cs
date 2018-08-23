using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Mobile.Droid.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App.Mobile.Droid.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainMenu : ContentPage
	{
        public MainMenu(string user)
        {
            User = user;
            InitializeComponent();
            LoadMenu();
            ListMenu.ItemsSource = MenuItems;
        }

        void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        => ((ListView)sender).SelectedItem = null;



        private void OnTapGestureRecognizerTapped(object sender, EventArgs e)
        {
            //Xamarin.Forms.Application.Current.MainPage.Navigation.PushAsync(new Config());
        }

        public ObservableCollection<MenuItemViewModel> MenuItems { get; set; }

        public string User { get; set; }


        public void LoadMenu()
        {

            MenuItems = new ObservableCollection<MenuItemViewModel>();

            //ImageSource.FromFile("@drawable/Logo.png");

            MenuItems.Add(new MenuItemViewModel
            {
                Id = 1,
                Icon = "Drawable/Recepcion.png",
                Name = "Recepcion",
                Page = "Pages/Recepcion/Search",
                UserLogin = User
            });
            MenuItems.Add(new MenuItemViewModel
            {
                Id = 2,
                Icon = "Drawable/Count.png",
                Name = "Conteo",
                Page = "Pages/Count/PlanList",
                UserLogin = User
            });
            MenuItems.Add(new MenuItemViewModel
            {
                Id = 4,
                Icon = "Drawable/warehousetranfer.png",
                Name = "Transferencia entre Bodegas",
                Page = "Pages/WarehouseTransfer/SubMenu",
                UserLogin = User
            });
            MenuItems.Add(new MenuItemViewModel
            {
                Id = 5,
                Icon = "Drawable/exit.png",
                Name = "Salida a Producción",
                Page = "Pages/Count/PlanList"
            });
            MenuItems.Add(new MenuItemViewModel
            {
                Id = 6,
                Icon = "Drawable/cambio.png",
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


     

    }
}