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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }
        
        private async void btnAbrir_Clicked(object sender, EventArgs e)
        {

            string usuario = txtUser.Text;
            string clave = txtPass.Text;

            if ((usuario == "henry2022") && (clave == "uisrael2022"))
            {
                await Navigation.PushAsync(new Registro(usuario,clave));
            }
            else
            {
                lblResultado.Text = "El usuario o contraseña son incorrectos";
            }
                    
             

        }
    }
}