﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TravelRecordApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void loginButton_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(inputEmail.Text) && !string.IsNullOrEmpty(inputPassword.Text))
            {
                Navigation.PushAsync(new HomePage());
            }
            else
            {
                dataValid.Text = "Something is wrong!";
            }

        }
    }
}
