﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WeatherApp.Model
{
    public class DayItemModel
    {
        internal int windSpeed;

        public int hour { get; set; }
        public WeatherType weatherType { get; set; }
        public int humid { get; set; }
        public int temp { get; set; }
        public WindType wind { get; set; }
        public UvType uv { get; set; }
        public Color uiColor { get; set; }
        public string imageName { get; set; }


    }
}
