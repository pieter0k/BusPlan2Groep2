﻿using System;
using System.Net;
using System.Net.Security;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BusPlan2Xamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());
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
