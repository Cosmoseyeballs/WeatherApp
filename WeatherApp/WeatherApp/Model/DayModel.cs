using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Model
{
    public class DayModel
    {
        public DateTime Date { get; set; }
        public List<DayItemModel> Hours { get; set; }
    }
}
