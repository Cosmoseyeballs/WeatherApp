using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WeatherApp.ViewModel;
using Xamarin.Forms;

namespace WeatherApp
{
    public class App : Application
    {
        IDayViewModel dayViewModel = new DayViewModel();
        public App()
        {
            // The root page of your application
            MainPage = new NavigationPage( new HomePage(dayViewModel));
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
