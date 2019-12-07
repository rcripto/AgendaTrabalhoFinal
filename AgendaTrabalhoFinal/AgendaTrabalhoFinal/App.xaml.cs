using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AgendaTrabalhoFinal.Database;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace AgendaTrabalhoFinal
{
    public partial class App : Application
    {
        private static EventoItemDatabase database;
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        internal static EventoItemDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new EventoItemDatabase(DependencyService.Get<iFileHelper>().GetLocalFilePath("EventoSQLite.db3"));
                }
                return database;
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
