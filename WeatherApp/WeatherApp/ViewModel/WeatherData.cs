using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Model;
using Xamarin.Forms;

namespace WeatherApp.ViewModel
{
    public static class WeatherData
    {
        public static List<UvType> GetUv()
        {
            return new List<UvType>()
            {
                new UvType { Name="U", Color = Color.Red },
                new UvType { Name="L", Color = Color.Yellow }

            };
        }


        public static List<WindType> GetWind()
        {
            return new List<WindType>()
            {
                new WindType { Name = "n", Direction = 0},
                new WindType { Name = "ne",Direction = 45},
                new WindType { Name = "e" ,Direction = 90},
                new WindType { Name = "se" ,Direction = 135 },
                new WindType { Name = "s" ,Direction = 180},
                new WindType { Name = "sw",Direction = 225 },
                new WindType { Name = "w",Direction = 270},
                new WindType { Name = "nw" ,Direction= 315},

            };
        }

        public static List<WeatherType> GetWeatherType()
        {
            return new List<WeatherType>()
            {
                new WeatherType { imageName = "weather10", Name="Rain" },
                new WeatherType { imageName = "weather34", Name="Sunny with cludes" },
                new WeatherType { imageName = "weather32", Name="Sunny" },

            };
        }


        public static DayModel GetDay(int id)
        {
            return AllDays()[id];
        }
        public static List<DayModel> GetDays()
        {
            return AllDays();
        }

        private static List<Model.DayModel> AllDays()
        {
            return new List<Model.DayModel>()
            {
                new DayModel
                {
                    Date=new DateTime(2016,6,9),
                    Hours=  new List<DayItemModel>() {
                        new Model.DayItemModel {
                            hour = 0,
                            humid = 98,
                            temp = 13,
                            uv = GetUv()[0],
                            weatherType = GetWeatherType()[0],
                            wind=  GetWind()[0],
                            windSpeed = 5

                        },
                        new Model.DayItemModel {
                            hour = 3,
                            humid = 86,
                            temp = 18,
                            uv = GetUv()[0],
                            weatherType = GetWeatherType()[0],
                            wind= GetWind()[1],
                            windSpeed = 10

                        },
                        new Model.DayItemModel {
                            hour = 6,
                            humid = 60,
                            temp = 19,
                            uv = GetUv()[1],
                            weatherType = GetWeatherType()[1],
                            wind= GetWind()[1],
                            windSpeed = 22
                        },
                        new Model.DayItemModel {
                            hour = 9,
                            humid = 10,
                            temp = 25,
                            uv = GetUv()[1],
                            weatherType = GetWeatherType()[1],
                            wind= GetWind()[2],
                            windSpeed = 22
                        },
                        new Model.DayItemModel {
                            hour = 12,
                            humid = 10,
                            temp = 28,
                            uv = GetUv()[1],
                            weatherType = GetWeatherType()[2],
                            wind= GetWind()[2],
                            windSpeed = 15
                        },
                        new Model.DayItemModel {
                            hour = 15,
                            humid = 5,
                            temp = 32,
                            uv = GetUv()[1],
                            weatherType = GetWeatherType()[2],
                            wind= GetWind()[3],
                            windSpeed = 5
                        }

                    }
                },
                new DayModel
                {
                    Date=new DateTime(2016,6,10),
                    Hours=  new List<DayItemModel>() {
                        new Model.DayItemModel {
                            hour = 0,
                            humid = 98,
                            temp = 13,
                            uv = GetUv()[0],
                            weatherType = GetWeatherType()[0],
                            wind=  GetWind()[0],
                            windSpeed = 5

                        },
                        new Model.DayItemModel {
                            hour = 3,
                            humid = 86,
                            temp = 18,
                            uv = GetUv()[0],
                            weatherType = GetWeatherType()[0],
                            wind= GetWind()[1],
                            windSpeed = 10

                        },
                        new Model.DayItemModel {
                            hour = 6,
                            humid = 60,
                            temp = 19,
                            uv = GetUv()[1],
                            weatherType = GetWeatherType()[1],
                            wind= GetWind()[1],
                            windSpeed = 22
                        },
                        new Model.DayItemModel {
                            hour = 9,
                            humid = 10,
                            temp = 25,
                            uv = GetUv()[1],
                            weatherType = GetWeatherType()[1],
                            wind= GetWind()[2],
                            windSpeed = 22
                        },
                        new Model.DayItemModel {
                            hour = 12,
                            humid = 10,
                            temp = 28,
                            uv = GetUv()[1],
                            weatherType = GetWeatherType()[2],
                            wind= GetWind()[2],
                            windSpeed = 15
                        },
                        new Model.DayItemModel {
                            hour = 15,
                            humid = 5,
                            temp = 32,
                            uv = GetUv()[1],
                            weatherType = GetWeatherType()[2],
                            wind= GetWind()[3],
                            windSpeed = 5
                        }

                    }
                },
                new DayModel
                {
                    Date=new DateTime(2016,6,11),
                    Hours=  new List<DayItemModel>() {
                        new Model.DayItemModel {
                            hour = 0,
                            humid = 98,
                            temp = 13,
                            uv = GetUv()[0],
                            weatherType = GetWeatherType()[0],
                            wind=  GetWind()[0],
                            windSpeed = 5

                        },
                        new Model.DayItemModel {
                            hour = 3,
                            humid = 86,
                            temp = 18,
                            uv = GetUv()[0],
                            weatherType = GetWeatherType()[0],
                            wind= GetWind()[1],
                            windSpeed = 10

                        },
                        new Model.DayItemModel {
                            hour = 6,
                            humid = 60,
                            temp = 19,
                            uv = GetUv()[1],
                            weatherType = GetWeatherType()[1],
                            wind= GetWind()[1],
                            windSpeed = 22
                        },
                        new Model.DayItemModel {
                            hour = 9,
                            humid = 10,
                            temp = 25,
                            uv = GetUv()[1],
                            weatherType = GetWeatherType()[1],
                            wind= GetWind()[2],
                            windSpeed = 22
                        },
                        new Model.DayItemModel {
                            hour = 12,
                            humid = 10,
                            temp = 28,
                            uv = GetUv()[1],
                            weatherType = GetWeatherType()[2],
                            wind= GetWind()[2],
                            windSpeed = 15
                        },
                        new Model.DayItemModel {
                            hour = 15,
                            humid = 5,
                            temp = 32,
                            uv = GetUv()[1],
                            weatherType = GetWeatherType()[2],
                            wind= GetWind()[3],
                            windSpeed = 5
                        }

                    }
                }
            };
        }
    }
}
