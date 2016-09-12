using System;
using System.Collections.Generic;
using WeatherApp.ViewModel;
using WeatherApp.Model;


namespace WeatherApp.ViewModel
{
    public class DayViewModel : IDayViewModel
    {
        public DayModel GetDay(int id)
        {
            return WeatherData.GetDay(id);
        }

        public IEnumerable<DayModel> GetDays()
        {
            return WeatherData.GetDays();
        }
    }
}