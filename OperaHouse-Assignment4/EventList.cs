using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperaHouse_Assignment5
{
    public class EventList
    {
        public List<Event> events;

        public List<Event> Events { get { return events; } }
        public EventList()
        {
            events = new List<Event>();
        }

        public void AddEvent(Event e)
        {
            events.Add(e);
        }
        public void RemoveEvent(Event e)
        {
            events.Remove(e);
        }
     
        public void AddEvent(List<Event> events)
        {
            this.events.AddRange(events);
        }
        
        public string[] eventIDs()
        {
            string[] ids = new string[events.Count];
            int i = 0;
            foreach (Event e in events)
            {
                ids[i] = e.ID;
                i++;
            }
            return ids;
        }

        public void SortByDate()
        {
            events.Sort(new DateComparer());

        }

        public void SortByTitle()
        {
            events.Sort(new TitleComparer());
        }

        public List<Event> SearchByPerformer(string name)
        {
            List<Event> results = new List<Event>();
            foreach (Event e in events)
            {
                if (e.Performer.Name.Equals(name))
                    results.Add(e);
            }
            return results;
        }

        public List<Event> OpenShows()
        {
            List<Event> result = new List<Event>();
            foreach (Event e in events)
            {
                if (e.NumAvailableTickets > 0)
                {
                    result.Add(e);
                }
            }
            return result;
        }

        public void Sort()
        {
            events.Sort();
        }

        public List<Event> ShowsShorterThan(int minutes)
        {
            List<Event> results = new List<Event>();
            foreach (Event e in events)
            {
                if (e.DurationMinutes <= minutes)
                    results.Add(e);
            }
            return results;
        }
    }
}
