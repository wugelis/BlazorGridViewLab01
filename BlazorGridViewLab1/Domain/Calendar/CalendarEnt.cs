using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MingChi.Domain.Calendar
{
    public class CalendarEnt
    {
        public string EmployeeId { get; internal set; }
        public string EmployeeName { get; internal set; }
        public int Week { get; set; }
    }
}
