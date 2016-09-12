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
        //public static BindableProperty HourProperty = BindableProperty.Create(
        //    propertyName: "Hour",
        //    returnType: typeof(int),
        //    declaringType: typeof(OneDayWeatherListView),
        //    defaultValue: 0,
        //    defaultBindingMode: BindingMode.OneWay,
        //    propertyChanged: HandleHourChanged);


        //public static BindableProperty WeatherTypeProperty = BindableProperty.Create(
        //    propertyName: "WeatherType",
        //    returnType: typeof(string),
        //    declaringType: typeof(OneDayWeatherListView),
        //    defaultValue: 0,
        //    defaultBindingMode: BindingMode.OneWay,
        //    propertyChanged: HandleWeatherTypeChanged);

        //public static BindableProperty HumidProperty = BindableProperty.Create(
        //   propertyName: "Humid",
        //   returnType: typeof(string),
        //   declaringType: typeof(OneDayWeatherListView),
        //   defaultValue: 0,
        //   defaultBindingMode: BindingMode.OneWay,
        //   propertyChanged: HandleHumidChanged);

        //public static BindableProperty TempProperty = BindableProperty.Create(
        //  propertyName: "Temp",
        //  returnType: typeof(string),
        //  declaringType: typeof(OneDayWeatherListView),
        //  defaultValue: 0,
        //  defaultBindingMode: BindingMode.OneWay,
        //  propertyChanged: HandleTempChanged);
        //#endregion

        //#region Handle
        //private static void HandleHourChanged(BindableObject bindable, object oldValue, object newValue)
        //{
        //    var newView = (OneDayWeatherListView)bindable;
        //    newView.HourLabel.Text = (string)newValue;
        //}
        //private static void HandleWeatherTypeChanged(BindableObject bindable, object oldValue, object newValue)
        //{
        //    var newView = (OneDayWeatherListView)bindable;
        //    newView.WeatherTypeIcon.Source = ImageSource.FromFile((string)newValue);
        //}
        //private static void HandleHumidChanged(BindableObject bindable, object oldValue, object newValue)
        //{
        //    var newView = (OneDayWeatherListView)bindable;
        //    newView.HourLabel.Text = (string)newValue;
        //}
        //private static void HandleTempChanged(BindableObject bindable, object oldValue, object newValue)
        //{
        //    var newView = (OneDayWeatherListView)bindable;
        //    newView.HourLabel.Text = (string)newValue;
        //}
        //#endregion

        //#region fields
        //public int Hour
        //{
        //    get
        //    {
        //        return (int)GetValue(HourProperty);
        //    }
        //    set
        //    {
        //        SetValue(HourProperty, value);
        //    }
        //}

        //public string WeatherType
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

        //public string Humid
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
        //#endregion





    }
}
