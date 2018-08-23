using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using App.Mobile.Droid.Models;
using App.Mobile.Droid.Services;
using GalaSoft.MvvmLight.Command;
using Detail = App.Mobile.Droid.Pages.Change.DetailChangeP;
using Xamarin.Forms;

namespace App.Mobile.Droid.ViewModels
{
    public class OrderReqAddViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;


        private ProductChangeServices services;

        private ProductServices productServices;

        public OrderReqAddViewModel(string pedido, string cliente, string producto, string nombreProducto, int qty)
        {
            services = new ProductChangeServices();
            productServices = new ProductServices();

            Pedido = pedido;
            Cliente = cliente;
            Producto = producto;
            ProductName = nombreProducto;
            ConcatProducto = producto + " " + nombreProducto;
            Quantity = qty;
            //App.Current.MainPage.Navigation.NavigationStack.Last().FindByName<Entry>("EntPedido").Focus();
        }




        #region PROPERTIES


        private string _concatProducto;

        public string ConcatProducto
        {
            get { return _concatProducto; }
            set
            {
                _concatProducto = value;
                OnPropertyChanged("ConcatProducto");
            }
        }

        private string _pedido;

        public string Pedido
        {
            get { return _pedido; }
            set
            {
                _pedido = value;
                OnPropertyChanged("Pedido");
            }
        }

        private string _cliente;

        public string Cliente
        {
            get { return _cliente; }
            set
            {
                _cliente = value;
                OnPropertyChanged("Cliente");
            }
        }

        private string _producto;

        public string Producto
        {
            get { return _producto; }
            set
            {
                _producto = value;
                OnPropertyChanged("Producto");
            }
        }

        private string _productSearch;

        public string ProductSearch
        {
            get { return _productSearch; }
            set
            {
                _productSearch = value;
                OnPropertyChanged("ProductSearch");
            }
        }


        private string _messageSearch;

        public string MessageSearch
        {
            get { return _messageSearch; }
            set
            {
                _messageSearch = value;
                OnPropertyChanged("MessageSearch");
            }
        }

        private int _quantity;

        public int Quantity
        {
            get { return _quantity; }
            set
            {
                _quantity = value;
                OnPropertyChanged("Quantity");
            }
        }


        private string _codeProductSearch;

        public string CodeProductSearch
        {
            get { return _codeProductSearch; }
            set
            {
                _codeProductSearch = value;
                OnPropertyChanged("CodeProductSearch");
            }
        }


        private string _productName;

        public string ProductName
        {
            get { return _productName; }
            set
            {
                _productName = value;
                OnPropertyChanged("ProductName");
            }
        }



        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged == null)
                return;
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }


        #endregion





        #region METHODS

        private async void SearchProduct()
        {
            var result = await productServices.Search(ProductSearch);
            if (result != null)
            {
                if (result.Count == 1)
                {
                    CodeProductSearch = result.FirstOrDefault().Code;
                    MessageSearch = result.FirstOrDefault().Description;
                }
                else
                    MessageSearch = "Producto NO encontrado";

            }

        }

        private async void SaveProduct()
        {
            bool result = false;
            var items = new OrderReqDetailExtend();

            items.OrderReqCode = Pedido;
            items.ProductCode = Producto;
            items.ProductCodeChanged = CodeProductSearch;
            items.Quantity = Quantity;

            if (!string.IsNullOrEmpty(CodeProductSearch))
            {
                result = await services.UpdateDetail(items);
                if (result)
                {
                    await Xamarin.Forms.Application.Current.MainPage.Navigation.PushAsync(new Detail(Pedido));
                }
                else
                    await App.Current.MainPage.DisplayAlert("TSHIRT", "Error, consulte el Administrador", "OK");
            }
            else
                await App.Current.MainPage.DisplayAlert("TSHIRT", "Debe ingresar un producto", "OK");


        }
        #endregion



        #region COMMANDS

        public ICommand Save
        {
            get { return new RelayCommand(SaveProduct); }
        }

        public ICommand Search
        {
            get { return new RelayCommand(SearchProduct); }
        }

        public ICommand SearchClicImage
        {
            get { return new RelayCommand(SearchProduct); }
        }
        #endregion



    }
}
