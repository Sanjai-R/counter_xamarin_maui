using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace counter
{
    public partial class App : Application
    {
        public int count = 0;
        public App ()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

       

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }
    }
}

