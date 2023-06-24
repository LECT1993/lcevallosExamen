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
    public partial class Resumen : ContentPage
    {
        public Resumen(string usuarioglobal, string nombre, string apellido, string edad, string fecha, string pais, string ciudad, string montoIni, string pagoMens, string pagoTotal)
        {
            InitializeComponent();
            lblUsuario.Text = "Usuario Conectado: " + usuarioglobal;
            txtNombre.Text = nombre;
            txtApellido.Text = apellido;
            txtEdad.Text = edad;
            txtFecha.Text = fecha;
            txtPais.Text = pais;
            txtCiudad.Text = ciudad;
            txtMontoInicial.Text = montoIni;
            txtPagoMensual.Text = pagoMens;
            txtPagoTotal.Text = pagoTotal;
        }

        private void btnCerrar_Clicked(object sender, EventArgs e)
        {
            

            Navigation.PushAsync(new Login());
        }
    }
}