using System;
using Microsoft.Maui.Controls.Xaml;
using Microsoft.Maui.Controls;
using Microsoft.Maui;

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

