using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace lcevallosExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
            txtUsuario.Text = "";
            txtContrasena.Text = "";
        }

        private void btnIniciar_Clicked(object sender, EventArgs e)
        {
            string usuario = "estudiante2023";
            string contrasena = "uisrael2023";

            if (usuario == txtUsuario.Text && contrasena == txtContrasena.Text)
            {
                Navigation.PushAsync(new Registro(usuario));
            }
            else
            {
                DisplayAlert("Alerta", "Usuario o contraseña incorrectos", "Cerrar");
            }

            
        }
    }
}