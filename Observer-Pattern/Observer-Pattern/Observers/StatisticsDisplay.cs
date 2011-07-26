using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Observer_Pattern.Display;

namespace Observer_Pattern.Observers
{
    public class StatisticsDisplay : Observer,DisplayElement
    {
        public void update(float temperature, float humidity, float pressure)
        { 
        }

        public void display()
        {
        }
    }
}
