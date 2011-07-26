using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Observer_Pattern.Display;
using Observer_Pattern.Subjects;

namespace Observer_Pattern.Observers
{
    public class CurrentConditions : Observer,DisplayElement
    {
        private float temperature;
        private float humidity;
        private Subject weatherData;

        public CurrentConditions(Subject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }

        public void update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            display();
        }

        public void display()
        {
            Console.WriteLine("Current conditions: " + temperature.ToString() + "F degress and " + humidity.ToString() + "% humidity");
        }


    }
}
