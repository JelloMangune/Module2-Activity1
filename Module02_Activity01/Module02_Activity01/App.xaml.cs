﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Module02_Activity01
{
    public partial class App : Application
    {
        public App ()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new View.Page1());
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

