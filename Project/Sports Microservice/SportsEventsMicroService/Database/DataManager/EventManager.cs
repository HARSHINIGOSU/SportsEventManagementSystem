using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SportsEventsMicroService.Database;
using SportsEventsMicroService.Database.Repository;

namespace SportsEventsMicroService.Database.DataManager
{
    public class EventManager : IDataRepository<Event>
    {
        readonly DatabaseContext _Eventcontext;
        public EventManager(DatabaseContext eventcontext)
        {
            _Eventcontext = eventcontext;
        }
        public IEnumerable<Event> GetAll()
        {
            return _Eventcontext.Events.ToList();
        }
        public Event Get(int id)
        {
            return _Eventcontext.Events.FirstOrDefault(e => e.EventId == id);
        }
        public bool Add(Event entity)
        {

            Sport sport = _Eventcontext.Sports.Where(e => e.SportName == entity.Sport.SportName).FirstOrDefault();
            Event e = new Event { EventName = entity.EventName, Date = entity.Date, NoOfSlots = entity.NoOfSlots, SportId = sport.SportId };
             _Eventcontext.Events.Add(e);
            _Eventcontext.SaveChanges();
            return true;
        }

        public bool Delete(Event @event)
        {
            _Eventcontext.Events.Remove(@event);
            _Eventcontext.SaveChanges();
            return true;
        }
        public Event GetByName(string name)
        {
            return _Eventcontext.Events.FirstOrDefault(e => e.EventName == name);
        }

    }
}
