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
    public partial class Add : ContentPage
    {
        public Add(string pedido, string cliente, string producto, string NombreProducto, int quantity)
        {
            InitializeComponent();
            BindingContext = new OrderReqAddViewModel(pedido, cliente, producto, NombreProducto, quantity);
        }
    }
}