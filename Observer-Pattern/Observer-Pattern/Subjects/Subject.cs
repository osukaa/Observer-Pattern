using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Observer_Pattern.Observers;

namespace Observer_Pattern.Subjects
{
    public interface Subject
    {
        void registerObserver(Observer o);
        void removeObserver(Observer o);
        void notifyObservers();
    }
}
