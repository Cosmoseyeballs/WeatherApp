using System.Collections.Generic;
using WeatherApp.Model;

namespace WeatherApp.ViewModel
{
   public interface IDayViewModel
    {
        IEnumerable<DayModel> GetDays();
        DayModel GetDay(int id);
    }
}