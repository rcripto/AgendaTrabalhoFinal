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
	public partial class EventoManter : ContentPage
	{
		public EventoManter ()
		{
			InitializeComponent ();

            dPDataEvento.Date = DateTime.Now.ToLocalTime();
            tPHoraInicial.Time = DateTime.Now.ToLocalTime().TimeOfDay;
            tPHoraFinal.Time = DateTime.Now.ToLocalTime().TimeOfDay;
        }

        void OnDateSelected(object sender, DateChangedEventArgs args)
        {
            Recalcular();
        }

        void OnSwitchToggled(object sender, ToggledEventArgs args)
        {
            Recalcular();
        }

        void Recalcular()
        {
            //lblData.Text = e.NewDate.Day + "/" + e.NewDate.Month + "/" + e.NewDate.Year;
        }

        private async void OnSaveEvento(object sender, EventArgs args)
        {
            var evento = (Evento)BindingContext;
            await App.Database.SaveItemAsync(evento);
            await Navigation.PopAsync();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}