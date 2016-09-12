using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace WeatherApp
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();

            List < int > tempList = new List<int>()
            {
                1,2,3,4,5,6
            };
            
            foreach (var item in tempList)
            {
                var temp = new OneDayWeatherListView();
               // temp.BindingContext = 
                WeatherFore4days.Children.Add(temp);
            }
            

        }
    }
}
