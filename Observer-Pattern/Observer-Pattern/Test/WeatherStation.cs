using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Observer_Pattern.Observers;
using Observer_Pattern.Subjects;
using Observer_Pattern.Display;

namespace Observer_Pattern.Test
{
    class WeatherStation
    {
        public void main()
        {
            WeatherData weatherData = new WeatherData();

            CurrentConditions currentDisplay = new CurrentConditions(weatherData);

            weatherData.setMeasurements(80, 65, 30.4f);
            weatherData.setMeasurements(82, 70, 29.2f);
            weatherData.setMeasurements(78, 90, 29.2f);
        }
    }
}
