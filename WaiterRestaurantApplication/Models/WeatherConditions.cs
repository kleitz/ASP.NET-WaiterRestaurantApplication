﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WaiterRestaurantApplication.Models
{
    public class WeatherConditions
    {
        public int WeatherConditionsId { get; set; }
        public int Temperature { get; set; }
        public string WeatherDescription { get; set; }
    }
}