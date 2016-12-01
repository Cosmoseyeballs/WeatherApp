using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Model;
using Xamarin.Forms;

namespace WeatherApp
{
    public partial class OneDayWeatherListView : Grid
    {

        public OneDayWeatherListView(DayItemModel item)
        {
            InitializeComponent();

            Debug.WriteLine("OneDayWeatherListView -> {0} {1} {2}", item.weatherType.Name, item.uv.Color, item.humid);

            this.SetBinding(OneDayWeatherListView.HourProperty, nameof(item.hour));
            this.SetBinding(OneDayWeatherListView.WeatherTypeProperty, "weatherType.imageName");

            this.SetBinding(OneDayWeatherListView.HumidProperty, nameof(item.humid));
            this.SetBinding(OneDayWeatherListView.UvColorProperty, "uv.Color"); // nameof(item.uv.Color));
            this.SetBinding(OneDayWeatherListView.UvNameProperty, "uv.Name"); // nameof(item.uv.Color));



        }


        //#region propertyes
        public static BindableProperty HourProperty = BindableProperty.Create(
            propertyName: nameof(hour),
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

        public static BindableProperty UvColorProperty = BindableProperty.Create(
          propertyName: nameof(uiColor),
          returnType: typeof(Color),
          declaringType: typeof(OneDayWeatherListView),
          defaultValue: Color.Aqua,
          defaultBindingMode: BindingMode.OneWay,
          propertyChanged: HandleUvColorChanged);

        public static BindableProperty UvNameProperty = BindableProperty.Create(
         propertyName: nameof(uvName),
         returnType: typeof(string),
         declaringType: typeof(OneDayWeatherListView),
         defaultValue: "",
         defaultBindingMode: BindingMode.OneWay,
         propertyChanged: HandleUvNameChanged);

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

        private static void HandleUvNameChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var newView = (OneDayWeatherListView)bindable;
            var h = (string)newValue;
            newView.UvLabel.Text = h;
        }

        private static void HandleUvColorChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var newView = (OneDayWeatherListView)bindable;
            var h = (Color)newValue;
            Debug.WriteLine("********************************** \n ColorChanged === {0}", h);
            newView.UvColor2.BackgroundColor = h;
        }

        private static void HandleHourChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var newView = (OneDayWeatherListView)bindable;

            var h =  (int)newValue == 0? "0": newValue.ToString();
            Debug.WriteLine("********************************** \n HourChanged === {0}", h);
            newView.HourLabel.Text = h;
        }
        private static void HandleWeatherChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var newView = (OneDayWeatherListView)bindable;
            var h = (string)newValue;
            // ret newValue
            newView.WeatherTypeIcon.Source = ImageSource.FromFile(h);  //(string)newValue);
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
                return (string)GetValue(HumidProperty);
            }
            set
            {
                SetValue(HumidProperty, value);
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

        public Color uiColor
        {
            get
            {
                return (Color)GetValue(UvColorProperty);
            }
            set
            {
                SetValue(UvColorProperty, value);
            }
        }


        public string uvName
        {
            get
            {
                return (string)GetValue(UvColorProperty);
            }
            set
            {
                SetValue(UvColorProperty, value);
            }
        }
        //#endregion





    }
}
