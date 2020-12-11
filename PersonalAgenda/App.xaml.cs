using System;
using PersonalAgenda.Data;
using System.IO;

namespace PersonalAgenda
{
    public partial class App : Application
    {
        static AgendaDatabase Database;

        public static AgendaDatabase Database
        {
            get
            {
                if (Database == null)
                {
                    Database = new
                        AgendaDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.
LocalApplicationData), "Notes.db3"));
                }
                return Database;
            }
        }

        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new AgendaPage());
        }

                    MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
