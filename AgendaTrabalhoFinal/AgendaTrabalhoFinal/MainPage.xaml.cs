using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AgendaTrabalhoFinal
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (e == null)
            {
                return;
            }

            var eventoManter = new EventoManter();
            Navigation.PushModalAsync(eventoManter);
        }
    }
}
