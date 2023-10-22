using Firebase.Database.Query;
using FunerariaApp.Models;
using FunerariaApp.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FunerariaApp.ViewModels
{
    public class MVUsuario
    {
        List<MUsuarios> usuarioData = new List<MUsuarios>();
        string IdUsuario;
        public async Task<List<MUsuarios>> Mostrar_Usuario()
        {
            var usuario = await Conexionfirebase.firebase
                .Child("Usuarios")
                .OnceAsync<MUsuarios>();

            foreach (var user in usuario)
            {
                MUsuarios mUsuarios = new MUsuarios();
                mUsuarios.Id_Cliente = user.Key;
                mUsuarios.Nombres = user.Object.Nombres;
                mUsuarios.Correo = user.Object.Correo;
                mUsuarios.Telefono = user.Object.Telefono;
                mUsuarios.Consulta = user.Object.Consulta;

                usuarioData.Add(mUsuarios);
            }
            return usuarioData;
        }
        public async Task<string> InsertarUsuario(MUsuarios parametro)
        {
            var data = await Conexionfirebase.firebase
                .Child("Usuarios")
                .PostAsync(new MUsuarios()
                {
                    Nombres = parametro.Nombres,
                    Correo = parametro.Correo,
                    Telefono = parametro.Telefono,
                    Consulta = parametro.Consulta
                });
            IdUsuario = data.Key;
            return IdUsuario;
        }
    }
}
