using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace lcevallosExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        string usuarioglobal;
        public Registro(string usuario)
        {
            InitializeComponent();
            lblUsuario.Text = "Usuario Conectado: " + usuario;
            usuarioglobal = usuario;
        }

        private void txtMontoInicial_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double montoI = Convert.ToDouble(txtMontoInicial.Text);
                if (montoI > 1499.99 || montoI<0)
                {
                    DisplayAlert("Error", "El monto inicial debe ser menor a $1500 y mayor a $0", " Cerrar");
                    txtMontoInicial.Text = "";
                }
            }
            catch (Exception)
            {


            }
        }

        private void btnCalculo_Clicked(object sender, EventArgs e)
        {
            double montoInicial = Convert.ToDouble(txtMontoInicial.Text);
            double resto = 1500 - montoInicial;
            double cuota = (resto/4 ) + (1500 * 0.04);
            string cuotatxt = Convert.ToString(cuota);

            txtPagoMensual.Text = cuotatxt;
        }

        private void btnResumen_Clicked(object sender, EventArgs e)
        {
            double montoInicial = Convert.ToDouble(txtMontoInicial.Text);
            double resto = 1500 - montoInicial;
            double cuota = (resto / 4) + (1500 * 0.04);
            double total = (cuota * 4) + montoInicial;

            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string edad = txtEdad.Text;
            string fecha = Convert.ToString(dpFecha);
            string pais = pkpaises.SelectedItem as string;
            string ciudad = pkciudades.SelectedItem as string;
            string montoIni = txtMontoInicial.Text;
            string pagoMens = txtPagoMensual.Text;
            string pagoTotal = Convert.ToString(total);

            Navigation.PushAsync(new Resumen(usuarioglobal, nombre, apellido, edad, fecha, pais, ciudad, montoIni, pagoMens, pagoTotal));
        }
    }
}