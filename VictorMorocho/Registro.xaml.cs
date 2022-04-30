using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VictorMorocho
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro(String usuario, String clave)
        {
            InitializeComponent();
            lblUser.Text = "Usuario conectado " + usuario;
        }

        private void btnTotal_Clicked(object sender, EventArgs e)
        {

            double montototal = 3000;
            double primeraporte = Convert.ToDouble(txtMontoInicial.Text);

            double valordiferencia = montototal - primeraporte; // valor de la diferencia de 3000

            double primerdiferido = (valordiferencia / 5);// valor sin el 5%

            double valor5 = (montototal * 0.05) / 5; // porcentaje del 5% dividido para 5 meses

            txtPagoMensual.Text = Convert.ToString(primerdiferido + valor5);


        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtPagoMensual.Text))
            {
                DisplayAlert("Alerta!!", "Favor realizar el calculo", "Salir");
            }
            else
            {

                DisplayAlert("Datos Guardados!!", "Elemento guardado con exito", "Salir");
                string usuario = lblUser.Text;
                string nombreEstudiante = txtNombre.Text;
                double primerAbono = Convert.ToDouble(txtMontoInicial.Text);
                double pagomensual = Convert.ToDouble(txtPagoMensual.Text);
                
                await Navigation.PushAsync(new Resumen(usuario, nombreEstudiante, primerAbono, pagomensual));
            }

        }
    }
}