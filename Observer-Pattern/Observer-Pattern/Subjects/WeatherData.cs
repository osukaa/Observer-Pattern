using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Observer_Pattern.Observers;

namespace Observer_Pattern.Subjects
{
    public class WeatherData : Subject
    {
        private List<Observer> observers;
        private float temperature;
        private float humidity;
        private float pressure;

        public WeatherData()
        {
            observers = new List<Observer>();
        }
            
        public void registerObserver(Observer o)
        {
            observers.Add(o);
        }

        public void removeObserver(Observer o)
        {
            observers.Remove(o);
        }

        public void notifyObservers()
        {
            foreach (Observer o in observers)
            {
                o.update(temperature, humidity, pressure);
            }
        }

        public float getTemperature() 
        {
            return this.temperature;
        }

        public float getHumidity()
        {
            return this.humidity;
        }

        public float getPressure()
        {
            return this.pressure;
        }

        public void measurementsChanged()
        {
            notifyObservers();
        }

        public void setMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            measurementsChanged();
        }
    }
}
