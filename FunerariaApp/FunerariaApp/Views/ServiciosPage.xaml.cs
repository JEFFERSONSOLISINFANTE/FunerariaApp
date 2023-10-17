using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
[assembly: ExportFont("Ballet.ttf", Alias = "Ballet")]
namespace FunerariaApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ServiciosPage : ContentPage
    {
        public ServiciosPage()
        {
            InitializeComponent();
        }

        public async void Carroceria_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Carroceria());
        }
        public async void Cremacion_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Cremacion());
        }
        public async void Ataud_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Ataud());
        }
    }
}