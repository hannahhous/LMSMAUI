﻿using LMSMaui.ViewModels;
namespace LMSMaui;


public partial class MainPage : ContentPage
{

	public MainPage()
        {
            InitializeComponent();
            //BindingContext = new MainViewViewModel();
        }

        private void StudentClicked(object sender, EventArgs e)
        {
            //Shell.Current.GoToAsync("//Student");
        }
        private void InstructorClicked(object sender, EventArgs e)
        {
            //Shell.Current.GoToAsync("//Instructor");
        }


}

