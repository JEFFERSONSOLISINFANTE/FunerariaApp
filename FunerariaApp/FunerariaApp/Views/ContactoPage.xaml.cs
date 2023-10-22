using FunerariaApp.Models;
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
    public partial class ContactoPage : ContentPage
    {
        public ContactoPage()
        {
            InitializeComponent();
        }

        private void btnGuardar_Clicked(object sender, EventArgs e)
        {
            guardarContacto();
        }

        private async Task guardarContacto()
        {
            MUsuarios mUsuarios = new MUsuarios();
            MVUsuario metodo = new MVUsuario();

            mUsuarios.Nombres = nombres.Text;
            mUsuarios.Correo = Correo.Text;
            mUsuarios.Telefono = Telefono.Text;
            mUsuarios.Consulta = Consulta.Text;

            await metodo.InsertarUsuario(mUsuarios);
            await DisplayAlert("alert", "Usuario guardado con exito", "OK");
        }
    }
}