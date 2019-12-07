using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using AgendaTrabalhoFinal.Model;

namespace AgendaTrabalhoFinal
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            ListView.ItemsSource = await App.Database.GetItemsAsync();
        }

        private void onItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            if (args != null)
            {
                Navigation.PushAsync(new PageEventoView()
                {
                    BindingContext = args.SelectedItem as Evento
                });
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EventoManter
            {
                BindingContext = new Evento()
            });
        }
    }
}
