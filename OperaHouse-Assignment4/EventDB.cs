using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperaHouse_Assignment5
{
    public class EventDB
    {
        public static EventList AllEvents()
        {
            Event shrek1, shrek2, shrek3, deathShow, belushiShow, grease;
            Stage main, lounge;
            Performer drDeath;
            Performer belushi;
            Performer osawaHigh;
            EventList events;

            osawaHigh = new Performer("Osawa High School", 0);
            drDeath = new Performer("Dr Death", 1500);
            belushi = new Performer("Jim Belushi", 3500);

            shrek1 = new Event("1", "Shrek", osawaHigh, 150, 12, new DateTime(2015, 4, 18, 19, 30, 0), 60, true);
            shrek2 = new Event("4", "Shrek", osawaHigh, 150, 12, new DateTime(2015, 4, 19, 19, 30, 0), 60, true);
            shrek3 = new Event("5", "Shrek", osawaHigh, 150, 12, new DateTime(2015, 4, 20, 19, 30, 0), 60, true);

            deathShow = new Event("2", "Dr. Death's Musical Adventures", drDeath, 200, 20, new DateTime(2015, 4, 25, 19, 0, 0), 90, true);
            belushiShow = new Event("3", "Belushi and the Board of Comedy", belushi, 160, 33, new DateTime(2015, 3, 4, 19, 45, 0), 120, false);

            grease = new Event("6", "Grease", osawaHigh, 0, 20, new DateTime(2015, 4, 20, 18, 0, 0), 100, false);

            main = new Stage("Main Stage", 100, 150);
            lounge = new Stage("The Lounge", 75, 50);

            events = new EventList();
            events.AddEvent(new List<Event> { shrek1, shrek2, shrek3, deathShow, belushiShow, grease });

            return events;
        }
    }
}
