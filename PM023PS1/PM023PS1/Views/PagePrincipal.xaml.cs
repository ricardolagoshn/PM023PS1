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
    public partial class PagePrincipal : ContentPage
    {
        public PagePrincipal()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            listemple.ItemsSource = await App.Dbemple.ListaEmpleadosAll();

        }
        private void listemple_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private async void tlbadd_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.PageEmple());
        }

        private void tlbmapa_Clicked(object sender, EventArgs e)
        {

        }
    }
}