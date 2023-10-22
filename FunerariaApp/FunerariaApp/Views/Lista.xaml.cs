using FunerariaApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FunerariaApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Lista : ContentPage
    {
        MVUsuario mVUsuario = new MVUsuario();
        public Lista()
        {
            InitializeComponent();
            
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            var data = await mVUsuario.Mostrar_Usuario();
            dataListView.ItemsSource = data;
        }
    }
}