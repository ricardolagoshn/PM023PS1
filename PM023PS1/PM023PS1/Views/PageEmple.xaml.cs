using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PM023PS1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageEmple : ContentPage
    {
        public PageEmple()
        {
            InitializeComponent();
        }

        private async void btnagregar_Clicked(object sender, EventArgs e)
        {
            var emple = new Models.Empleado
            {
                nombres = txtnombre.Text,
                apellidos = txtapellido.Text,
                edad = Convert.ToInt32(txtedad.Text),
                correo = txtcorreo.Text
            };


            if (await App.Dbemple.StoreEmple(emple) > 0)
            {
                await DisplayAlert("Aviso", "Empleado Agregado", "OK");
            }
        }
    }
}