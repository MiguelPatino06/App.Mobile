using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Android.Support.V4.View;
using GalaSoft.MvvmLight.Command;
using App.Mobile.Droid.Pages.Change;
using App.Mobile.Droid.Pages.Count;
using App.Mobile.Droid.Pages.Reception;

namespace App.Mobile.Droid.Models
{
    public class MenuItemViewModel
    {
        public int Id { get; set; }
        public string Icon { get; set; }
        public string Name { get; set; }
        public string Page { get; set; }
        public string UserLogin { get; set; }

        public ICommand NavigateCommand
        {
            get { return new RelayCommand(Navigate); }
        }

        private void Navigate()
        {

            switch (Id)
            {
                case 1:
                    Xamarin.Forms.Application.Current.MainPage.Navigation.PushAsync(new Search());
                    break;
                case 2:
                    Xamarin.Forms.Application.Current.MainPage.Navigation.PushAsync(new PlanList(UserLogin));
                    break;
                //case 3:
                //    Xamarin.Forms.Application.Current.MainPage.Navigation.PushAsync(new Menu());
                //    break;
                case 4: //Transferencia entre Bodegas
                    Xamarin.Forms.Application.Current.MainPage.Navigation.PushAsync(new Pages.WarehouseTransfer.SubMenu());
                    break;
                case 5: //Salida a Producción
                    Xamarin.Forms.Application.Current.MainPage.Navigation.PushAsync(new Pages.Output.SubMenu());
                    break;
                case 6: // Cambio Producto
                    Xamarin.Forms.Application.Current.MainPage.Navigation.PushAsync(new Pages.Change.SubMenu());
                    break;
                //case 7: // "Muestra":
                //    Xamarin.Forms.Application.Current.MainPage.Navigation.PushAsync(new Pages.Transaction.Sample.SubMenu());
                //    break;
                //case 8: // Muestra -Crear Solicitud
                //    Xamarin.Forms.Application.Current.MainPage.Navigation.PushAsync(new Pages.Transaction.Sample.ClientProduct(null));
                //    break;
                //case 9: // Muestra Lista
                //    Xamarin.Forms.Application.Current.MainPage.Navigation.PushAsync(new Pages.Transaction.Sample.List());
                //    break;
                case 10: // Cambio Producto -Crear Solicitud
                    Xamarin.Forms.Application.Current.MainPage.Navigation.PushAsync(new Pages.Change.ClientProduct());
                    break;
                case 11: // Cambio Producto - Lista
                    Xamarin.Forms.Application.Current.MainPage.Navigation.PushAsync(new Pages.Change.List());
                    break;
                case 12: // Transferencia entre Bodegas - Crear Solicitud
                    Xamarin.Forms.Application.Current.MainPage.Navigation.PushAsync(new Pages.WarehouseTransfer.Warehouses());
                    break;
                case 13: // Transferencia entre Bodegas - Lista
                    Xamarin.Forms.Application.Current.MainPage.Navigation.PushAsync(new Pages.WarehouseTransfer.List());
                    break;
                case 14: // Salida a Producción - Crear Solicitud
                    Xamarin.Forms.Application.Current.MainPage.Navigation.PushAsync(new Pages.Output.OutputProducts());
                    break;
                case 15: // Salida a Producción - Lista
                    Xamarin.Forms.Application.Current.MainPage.Navigation.PushAsync(new Pages.Output.List());
                    break;
                //case 16: // Exit App                  
                //    //Xamarin.Forms.Application.Current.MainPage.Navigation.PushAsync(new Pages.Transaction.Output.List());
                //    break;
                default:
                    break;
            }
        }
    }
}
