using MingChi.Domain.Calendar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MingChi.CRMApplication.Calendars
{
    public interface ICalendarRepository
    {
        void Add(CalendarEnt calendarEnt);
    }
}
