using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Mobile.Droid.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App.Mobile.Droid.Pages.WarehouseTransfer
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SubMenu : ContentPage
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<MenuItemViewModel> Menu { get; set; }
        public SubMenu()
        {
            InitializeComponent();
            BindingContext = new SubMenuViewModelTransaction();

        }
        void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
       => ((ListView)sender).SelectedItem = null;

        private void OnTapPrevPage(object sender, EventArgs e)
        {
            Xamarin.Forms.Application.Current.MainPage.Navigation.PopAsync();
        }
    }
    public class SubMenuViewModelTransaction : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<MenuItemViewModel> Menu { get; set; }
        public SubMenuViewModelTransaction()
        {
            LoadMenu();
        }


        public void LoadMenu()
        {
            Menu = new ObservableCollection<MenuItemViewModel>();

            Menu.Add(new MenuItemViewModel
            {
                Id = 12,
                Icon = "@drawable/add.png",
                Name = "Crear Solicitud",
                Page = ""
            });
            Menu.Add(new MenuItemViewModel
            {
                Id = 13,
                Icon = "@drawable/list.png",
                Name = "Ver Solicitud",
                Page = ""
            });

        }


    }
}