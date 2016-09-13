using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Model;
using Xamarin.Forms;

namespace WeatherApp
{
    public partial class OneDayWeatherListView : Grid
    {
        public OneDayWeatherListView()
        {
            InitializeComponent();
        }


        //#region propertyes
        public static BindableProperty HourProperty = BindableProperty.Create(
            propertyName: "Hour",
            returnType: typeof(int),
            declaringType: typeof(OneDayWeatherListView),
            defaultValue: 0,
            defaultBindingMode: BindingMode.OneWay,
            propertyChanged: HandleHourChanged);


        public static BindableProperty WeatherTypeProperty = BindableProperty.Create(
            propertyName: nameof(weather),
            returnType: typeof(string), // imageName
            declaringType: typeof(OneDayWeatherListView),
            defaultValue: "",
            defaultBindingMode: BindingMode.OneWay,
            propertyChanged: HandleWeatherChanged);

        public static BindableProperty HumidProperty = BindableProperty.Create(
           propertyName: nameof(humid),
           returnType: typeof(int),
           declaringType: typeof(OneDayWeatherListView),
           defaultValue: 0,
           defaultBindingMode: BindingMode.OneWay,
           propertyChanged: HandleHumidChanged);

        //public static BindableProperty TempProperty = BindableProperty.Create(
        //  propertyName: "Temp",
        //  returnType: typeof(string),
        //  declaringType: typeof(OneDayWeatherListView),
        //  defaultValue: 0,
        //  defaultBindingMode: BindingMode.OneWay,
        //  propertyChanged: HandleTempChanged);

        //public static BindableProperty UiProperty = BindableProperty.Create(
        //   propertyName: "Ui",
        //   returnType: typeof(string),
        //   declaringType: typeof(OneDayWeatherListView),
        //   defaultValue: 0,
        //   defaultBindingMode: BindingMode.OneWay,
        //   propertyChanged: HandleUiChanged);

        //public static BindableProperty UiColorProperty = BindableProperty.Create(
        //   propertyName: "UiColor",
        //   returnType: typeof(string),
        //   declaringType: typeof(OneDayWeatherListView),
        //   defaultValue: 0,
        //   defaultBindingMode: BindingMode.OneWay,
        //   propertyChanged: HandleUiColorChanged);
        //#endregion

        //#region Handle
        private static void HandleHourChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var newView = (OneDayWeatherListView)bindable;
            var h = (int)newValue;
            newView.HourLabel.Text = h.ToString();
        }
        private static void HandleWeatherChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var newView = (OneDayWeatherListView)bindable;

            // ret newValue
            newView.WeatherTypeIcon.Source = ImageSource.FromFile("weather1.png");  //(string)newValue);
        }
        private static void HandleHumidChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var newView = (OneDayWeatherListView)bindable;
            var h = (int)newValue;

            newView.HumidLabel.Text = h.ToString();
        }
        //private static void HandleTempChanged(BindableObject bindable, object oldValue, object newValue)
        //{
        //    var newView = (OneDayWeatherListView)bindable;
        //    newView.TempLabel.Text = (string)newValue;
        //}

        //private static void HandleUiChanged(BindableObject bindable, object oldValue, object newValue)
        //{
        //    var newView = (OneDayWeatherListView)bindable;
        //    newView.UvLabel.Text = (string)newValue;
        //}

        //private static void HandleUiColorChanged(BindableObject bindable, object oldValue, object newValue)
        //{
        //    var newView = (OneDayWeatherListView)bindable;
        //    newView.UvColor.BackgroundColor = (Color)newValue;
        //}
        //#endregion

        //#region fields
        public int hour
        {
            get
            {
                return (int)GetValue(HourProperty);
            }
            set
            {
                SetValue(HourProperty, value);
            }
        }

        public string weather
        {
            get
            {
                return (string)GetValue(WeatherTypeProperty);
            }
            set
            {
                SetValue(WeatherTypeProperty, value);
            }
        }

        public string humid
        {
            get
            {
                return (string)GetValue(WeatherTypeProperty);
            }
            set
            {
                SetValue(WeatherTypeProperty, value);
            }
        }
        //public string Temp
        //{
        //    get
        //    {
        //        return (string)GetValue(WeatherTypeProperty);
        //    }
        //    set
        //    {
        //        SetValue(WeatherTypeProperty, value);
        //    }
        //}
        //public string Ui
        //{
        //    get
        //    {
        //        return (string)GetValue(WeatherTypeProperty);
        //    }
        //    set
        //    {
        //        SetValue(WeatherTypeProperty, value);
        //    }
        //}
        //public string UiColor
        //{
        //    get
        //    {
        //        return (string)GetValue(WeatherTypeProperty);
        //    }
        //    set
        //    {
        //        SetValue(WeatherTypeProperty, value);
        //    }
        //}
        //#endregion





    }
}
