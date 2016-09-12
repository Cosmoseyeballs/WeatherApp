using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.ViewModel;
using Xamarin.Forms;

namespace WeatherApp
{
    public partial class HomePage : ContentPage
    {
        IDayViewModel _dayViewModel = new DayViewModel();

        public HomePage(IDayViewModel dayViewModel)
        {
            _dayViewModel = dayViewModel;
            InitializeComponent();


            BindingContext = _dayViewModel.GetDay(0);

            foreach (var item in _dayViewModel.GetDay(0).Hours)
            {
                var temp = new OneDayWeatherListView();
                // temp.BindingContext = 
                OneDayWeatherList.Children.Add(temp);
            }






            List < int > tempList = new List<int>()
            {
                1,2,3,4,5,6
            };
            bool switchColor = true;
            foreach (var item in tempList)
            {
                var temp = new OneWeekWeatherView();
                // temp.BindingContext = 
                if (switchColor)
                {
                    temp.BackgroundColor = Color.FromRgba(1.0, 1.0, 1.0, 0.2);
                    
                }
                switchColor = !switchColor;
                OneWeekWeather.Children.Add(temp);
            }
        }
    }
}
