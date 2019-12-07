using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AgendaTrabalhoFinal.Model;

namespace AgendaTrabalhoFinal
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PageEventoView : ContentPage
	{
		public PageEventoView ()
		{
			InitializeComponent ();
		}

        private void OnEditEvento(object sender, EventArgs args)
        {
            if (args != null)
            {
                Navigation.PushAsync(new EventoManter()
                {
                    BindingContext = (Evento)BindingContext
                });
            }
        }

        private async void OnDeleteEvento(object sender, EventArgs args)
        {
            var answer = await DisplayAlert("Confirmar Exclusão", "Confirma a exclusão do evento?", "Sim", "Não");
            if (answer)
            {
                var evento = (Evento)BindingContext;
                await App.Database.DeleteItemAsync(evento);
                await Navigation.PopAsync();
            }
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}